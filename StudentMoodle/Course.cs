using Notify.Models;
using System;
using System.IO;

namespace StudentMoodle
{
    internal class Course
    {
        #region VARIABLE DECLARATION

        //private WebBrowser _browser;

        public int Id { get; set; }
        public string Name { get; set; }
        private int UserId { get; set; }

        #endregion VARIABLE DECLARATION

        public Course(int userId)
        {
            UserId = userId;

            if (!Directory.Exists($"NOTES/{Name}"))
            {
                CreateDirectory();
            }
        }

        private void CreateDirectory()
        {
            Directory.CreateDirectory($"NOTES/{Name}");
        }

        public void WriteCourseDataToDb()
        {
            using (var db = new NotifyLocalDBEntities())
            {
                var cours = new Cours
                {
                    courseName = Name,
                    portalCourseId = Id,
                    dateAdded = DateTime.Now,
                    userId = UserId
                };
                db.Courses.Add(cours);

                db.SaveChanges();
            }
        }
    }
}