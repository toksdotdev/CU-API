using System;
using System.IO;

namespace StudentMoodle.Parser
{
    public class CourseCreator
    {
        #region VARIABLE DECLARATION

        public int Id { get; set; }
        public string Name { get; set; }
        private int UserId { get; set; }

        #endregion VARIABLE DECLARATION

        public CourseCreator(int userId)
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

        public Course GetCourseData()
        {
            return new Course
            {
                courseName = Name,
                portalCourseId = Id,
                dateAdded = DateTime.Now,
                userId = UserId
            };
        }
    }
}