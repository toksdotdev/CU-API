using Notify.Models;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Notify.Classes
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
            this.UserId = userId;
        }

        public void CreateDirectory()
        {
            Name = Name;
            Directory.CreateDirectory($"NOTES/{Name}");
        }

        public void WriteCourseDataToDb()
        {
            using (var db = new NotifyLocalDBEntities())
            {
                db.Courses.Add(new Cours()
                {
                    courseName = Name,
                    portalCourseId = Id,
                    dateAdded = DateTime.Now,
                    userId = UserId
                });

                db.SaveChanges();
            }
        }
    }
}