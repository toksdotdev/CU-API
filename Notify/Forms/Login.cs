using LinqToDB;
using Notify.Classes;
using Notify.Models;
using System;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Notify.Forms
{
    public partial class Login : Form
    {
        private readonly TestingClass _k = new TestingClass();

        public Login()
        {
            InitializeComponent();
            _k.NavigatePage(new Uri("http://10.0.3.32"));

            _k.Browser.DocumentCompleted += Browser_DocumentCompleted;

            this.Controls.Add(_k.Browser);
            _k.Browser.Show();
            _k.Browser.Dock = DockStyle.Fill;
        }

        private static void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _k.NavigatePage(_k.GetProfileLink());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var courseData = _k.GetCoursesData();

            foreach (var data in courseData)
            {
                //#region WRITE COURSE DATA TO DB

                //using (var db = new NotifyLocalDBEntities())
                //{
                //    Cours newCourse = new Cours()
                //    {
                //        courseName = data.Name,
                //        portalCourseId = data.Id,
                //        userId = 1
                //    };

                //    db.Courses.Add(newCourse);
                //    db.SaveChanges();
                //}

                //#endregion WRITE COURSE DATA TO DB

                var result = _k.GetCourseNotesDownloadLinksById(data.Id);

                foreach (var res in result)
                {
                    var randomPathString = string.Format($"{data.Id}, {new Random().Next()}");

                    using (var db = new NotifyLocalDBEntities())
                    {
                        #region WRITE NOTE DATA TO DB

                        var newCourse = new Note
                        {
                            courseId = data.Id,
                            noteCustomPath = randomPathString,
                            dateDownloaded = DateTime.Now,
                            portalNoteId = Convert.ToInt32(res.Split('=')[1])
                        };
                        newCourse.noteName = _k.GetHtmlOfTagContainingKeyword("a", newCourse.portalNoteId.ToString())
                            .FirstOrDefault();

                        var count = 0;
                        try
                        {
                            count = ((from note in db.Notes select note.noteId).Max().Equals(null))
                                ? 1
                                : (from note in db.Notes select note.noteId).Max();
                        }
                        catch (Exception)
                        {
                            // ignored
                        }

                        //newCourse.noteId = (count.Equals(0)) ? count + 1 : 1;

                        db.Notes.Add(newCourse);

                        try
                        {
                            db.SaveChanges();
                        }
                        catch (DbEntityValidationException ex)
                        {
                            foreach (var eve in ex.EntityValidationErrors)
                            {
                                MessageBox.Show(
                                    $"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");
                                foreach (var ve in eve.ValidationErrors)
                                {
                                    MessageBox.Show($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                                }
                            }
                            throw;
                        }

                        #endregion WRITE NOTE DATA TO DB
                    }

                    #region DOWNLOAD NOTE

                    //
                    var downloaderEngine = new Downloader
                        .DownloadFile(res, $"NOTES/{data.Name}/{randomPathString}.pdf", DownloadCompleted);

                    #endregion DOWNLOAD NOTE

                    MessageBox.Show(res);
                }
            }
        }

        private static void DownloadCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            MessageBox.Show("completed download");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var randomPathString = $"{220}{new Random().Next()}";

            //Course NEWCOURS = new Course();
            ////NEWCOURS.DownloadNotes(k.Browser);
            //NEWCOURS.CreateDirectory();

            //Panel k = new Panel();
            //textBox1.Clear();

            var engine = new Downloader.DownloadFile(
                    "http://10.0.3.32/mod/resource/view.php?id=16272",
                    $"NOTES/{randomPathString}.pdf",
                    DownloadCompleted
               );

            engine.DownloadNow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //k.GetCourseNotesDownloadLinksById(220);
        }
    }
}