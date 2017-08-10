using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Notify.CustomControls;
using Notify.Models;

namespace Notify
{
    public partial class Dashboard : Form
    {
        private Color _tempBackColor = default(Color);
        private readonly List<Note> _noteCollection;

        /// <summary>
        /// Point for positioning of course button pills
        /// </summary>
        private Point _point = new Point(15, 80);

        /// <summary>
        /// A detailed collection of users courses
        /// </summary>
        private static IEnumerable<Cours> AllCoursesDetailsEnumerable
        {
            get
            {
                List<Cours> result;
                using (var db = new NotifyLocalDBEntities())
                {
                    result = (from course in db.Courses select course).ToList();
                }

                return result;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();
            _noteCollection = new List<Note>();
            windowExitButton1.BackColor = Color.Aqua;
        }

        /// <summary>
        /// Load all the pills into view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Generates button pills for each course
        /// </summary>
        private void LoadCoursesPills()
        {
            //Load Courses
            var courses = AllCoursesDetailsEnumerable;

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
                    LoadCourseNotesLabel(course1.courseId);
                };

                pillControl.Location = new Point(15, _point.Y + 10 + pillControl.Height);

                _point = new Point(8, pillControl.Location.Y);

                panel3.Controls.Add(pillControl);
                pillControl.Show();

                #endregion CREATE PILL BUTTON FOR EACH COURSE
            }
        }

        /// <summary>
        /// Generate label for all notes unser a course Id
        /// </summary>
        /// <param name="courseId"></param>
        private void LoadCourseNotesLabel(int courseId)
        {
            var noteData = GetCourseNotesFromDb(courseId);
            var location = new Point(9, 14);

            foreach (var note in noteData)
            {
                #region CREATE LINKLABEL FOR EACH NOTE IN A COURSE

                _noteCollection.Add(new Note
                {
                    noteName = note.noteName,
                    noteCustomPath = note.noteCustomPath
                });

                var linkLabel = new LinkLabel
                {
                    #region LINK LABEL CONTROL PROPERTIES

                    AutoSize = true,
                    BackColor = SystemColors.Window,
                    Font = new Font(
                        "Microsoft YaHei UI Light", 9F, FontStyle.Italic,
                        GraphicsUnit.Point, 0),
                    LinkColor = Color.DarkOliveGreen,
                    Size = new Size(187, 17)

                    #endregion LINK LABEL CONTROL PROPERTIES
                };

                #region LINK LABEL CONTROL PROPERTIES

                linkLabel.Location = new Point(9, location.Y + 10 + linkLabel.Size.Height);
                linkLabel.Name = note.noteCustomPath;
                linkLabel.TabStop = true;
                linkLabel.Text = $@">> {note.noteName}";

                #endregion LINK LABEL CONTROL PROPERTIES

                linkLabel.Click += delegate
                {
                    Process.Start($"NOTES/{GetCourseNameById(courseId)}/{note.noteCustomPath}.pdf");
                };

                notePanel.Controls.Add(linkLabel);

                linkLabel.Show();

                #endregion CREATE LINKLABEL FOR EACH NOTE IN A COURSE
            }
        }

        /// <summary>
        /// Retrieves all notes from DB for a single course
        /// </summary>
        /// <param name="courseId">Id of course</param>
        /// <returns>Notes for course</returns>
        private static IEnumerable<Note> GetCourseNotesFromDb(int courseId)
        {
            using (var db = new NotifyLocalDBEntities())
            {
                return
                    (from notes in db.Notes
                     where notes.courseId.Equals(courseId)
                     select notes).ToList();
            }
        }

        /// <summary>
        /// Get the course name of a course from its ID
        /// </summary>
        /// <param name="courseId">id of course to get its name</param>
        /// <returns>Name of id's course</returns>
        private static string GetCourseNameById(int courseId)
        {
            using (var db = new NotifyLocalDBEntities())
            {
                return (
                    from data in db.Courses
                    where data.courseId.Equals(courseId)
                    select data.courseName).FirstOrDefault();
            }
        }

        #region WINDOW BAR BUTTONS

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowExitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Minimise the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowExitButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Maximise the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowExitButton4_Click(object sender, EventArgs e)
        {
            WindowState = WindowState.Equals(FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        #endregion WINDOW BAR BUTTONS
    }
}