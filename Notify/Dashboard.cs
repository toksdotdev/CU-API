using Notify.Classes;
using Notify.CustomControls;
using Notify.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notify
{
    public partial class Dashboard : Form
    {
        private Color _tempBackColor = default(Color);
        private readonly List<Note> _noteCollection;

        public Dashboard()
        {
            InitializeComponent();
            _noteCollection = new List<Note>();
            windowExitButton1.BackColor = Color.Aqua;
        }

        private Point _point = new Point(15, 80);

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCoursesPills();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //do this asynchronously
        private void LoadCoursesPills()
        {
            var courses = GetAllCoursesDetails();

            //Load Courses
            foreach (var course in courses)
            {
                #region CREATE PILL BUTTON FOR EACH COURSE

                var pillControl = new PillControl
                {
                    Text = course.courseName,
                    PillBackColor = Color.OrangeRed
                };

                pillControl.MouseEnter += delegate
                {
                    _tempBackColor = pillControl.PillBackColor;

                    pillControl.PillBackColor = Color.DarkSlateGray;
                };

                pillControl.MouseLeave += delegate
                {
                    pillControl.PillBackColor = _tempBackColor;
                };

                var course1 = course;
                pillControl.Click += delegate
                {
                    MessageBox.Show("clicked");
                    LoadCourseNotes(course1.courseId);
                };
                pillControl.Location = new Point(15, _point.Y + 10 + pillControl.Height);

                _point = new Point(8, pillControl.Location.Y);

                panel3.Controls.Add(pillControl);
                pillControl.Show();

                #endregion CREATE PILL BUTTON FOR EACH COURSE
            }
        }

        private void LoadCourseNotes(int courseId)
        {
            using (var db = new NotifyLocalDBEntities())
            {
                var noteData = (from notes in db.Notes
                                where notes.courseId.Equals(courseId)
                                select notes).ToList();
                var location = new Point(9, 14);

                foreach (var note in noteData)
                {
                    #region CREATE LINKLABEL FOR EACH NOTE IN A COURSE

                    _noteCollection.Add(new Note()
                    {
                        noteName = note.noteName,
                        noteCustomPath = note.noteCustomPath,
                    });

                    var linkLabel = new LinkLabel
                    {
                        #region LINK LABEL CONTROL PROPERTIES

                        AutoSize = true,
                        BackColor = System.Drawing.SystemColors.Window,
                        Font = new System.Drawing.Font(
                            "Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Italic,
                            System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        LinkColor = System.Drawing.Color.DarkOliveGreen,
                        Size = new System.Drawing.Size(187, 17)

                        #endregion LINK LABEL CONTROL PROPERTIES
                    };

                    #region LINK LABEL CONTROL PROPERTIES

                    linkLabel.Location = new Point(9, location.Y + 10 + linkLabel.Size.Height);
                    linkLabel.Name = note.noteCustomPath;
                    linkLabel.TabStop = true;
                    linkLabel.Text = $@">> {note.noteName}";

                    #endregion LINK LABEL CONTROL PROPERTIES

                    var note1 = note;
                    var result = (from data in db.Courses
                                  where data.courseId.Equals(courseId)
                                  select data.courseName).FirstOrDefault();

                    linkLabel.Click += delegate
                    {
                        Process.Start($"NOTES/{result}/{note1.noteCustomPath}.pdf");
                    };

                    panel4.Controls.Add(linkLabel);
                    linkLabel.Show();

                    #endregion CREATE LINKLABEL FOR EACH NOTE IN A COURSE
                }
            }
        }

        private static IEnumerable<string> GetCourseNames()
        {
            using (var db = new NotifyLocalDBEntities())
            {
                return (from course in db.Courses
                        select course.courseName).ToList();
            }
        }

        private static List<Cours> GetAllCoursesDetails()
        {
            List<Cours> result;
            using (var db = new NotifyLocalDBEntities())
            {
                result = (from course in db.Courses
                          select course).ToList();
            }

            return result;
        }

        private void windowExitButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void windowExitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void windowExitButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void windowExitButton4_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Maximized))
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }
    }
}