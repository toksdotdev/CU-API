using Notify.Models;
using StudentMoodle.Parser;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Notify.Forms
{
    public partial class Login : Form
    {
        private readonly MoodleParser _parser;

        public Login()
        {
            _parser = new MoodleParser();

            InitializeComponent();

            _parser.NavigateToMoodle();

            Controls.Add(_parser.Browser);

            _parser.Browser.Show();

            _parser.Browser.Dock = DockStyle.Fill;
        }

        //** Login
        //** PERFORM FIRST SYNC
        //      get details
        //      get notes
        //      download notes
        private void AutomateProcess()
        {
            GotoProfile();
            PerformFirstSynchronization();

            MessageBox.Show("Completed");
        }

        private void GotoProfile()
        {
            _parser.NavigatePage(_parser.GetProfileLink());
        }

        private void PerformFirstSynchronization()
        {
            var coursesData = _parser.GetCoursesData();

            foreach (var course in coursesData)
            {
                AddCourseToDb(course);

                ProcessCourseNotes(course, GetNotesLink(course.Id));
            }
        }

        private static string GenerateRandomPath(int id)
        {
            return string.Format($"{id}, {new Random().Next()}");
        }

        private static void AddCourseToDb(CourseCreator courseData)
        {
            #region WRITE COURSE DATA TO DB

            using (var db = new NotifyLocalDBEntities())
            {
                var newCourse = new Models.Cours()
                {
                    courseName = courseData.Name,
                    portalCourseId = courseData.Id,
                    userId = Properties.Settings.Default.UserId
                };

                db.Courses.Add(newCourse);
                db.SaveChanges();
            }

            #endregion WRITE COURSE DATA TO DB
        }

        private IEnumerable<string> GetNotesLink(int courseId)
        {
            return _parser.GetCourseNotesDownloadLinksById(courseId);
        }

        private void ProcessCourseNotes(CourseCreator courseData, IEnumerable<string> courseNotesDownloadLinks)
        {
            foreach (var noteDownloadLink in courseNotesDownloadLinks)
            {
                //generate unique name for each note
                var randomNoteName = GenerateRandomPath(courseData.Id);

                //write note details to db
                AddNoteToDb(courseData, randomNoteName, noteDownloadLink);

                //download courses notes
                DownloadCourseNotes(noteDownloadLink, courseData.Name, randomNoteName);
            }
        }

        private static void DownloadCourseNotes(string noteDownloadLink, string courseName, string noteName)
        {
            FileDownloader.Download(noteDownloadLink, $"NOTES/{courseName}/{noteName}.pdf", DownloadCompleted);
        }

        private void AddNoteToDb(CourseCreator courseData, string noteName, string downloadLink)
        {
            using (var db = new NotifyLocalDBEntities())
            {
                #region WRITE NOTE DATA TO DB

                var newCourseNote = new Models.Note
                {
                    courseId = courseData.Id,
                    noteCustomPath = noteName,
                    dateDownloaded = DateTime.Now,
                    portalNoteId = Convert.ToInt32(downloadLink.Split('=')[1])
                };

                newCourseNote.noteName = _parser.GetHtmlOfTagContainingKeyword("a", newCourseNote.portalNoteId.ToString()).FirstOrDefault();

                db.Notes.Add(newCourseNote);

                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    #region LOGGING

                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");

                        foreach (var ve in eve.ValidationErrors)
                        {
                            Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }

                    #endregion LOGGING
                }

                #endregion WRITE NOTE DATA TO DB
            }
        }

        private static void DownloadCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            Trace.TraceInformation("Completed all notes download");
        }
    }
}