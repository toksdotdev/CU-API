using System;
using System.IO;

namespace StudentMoodle.Parser
{
    public class CourseCreator
    {
        public CourseCreator(int userId)
        {
            UserId = userId;

            if (!Directory.Exists($"NOTES/{Name}"))
                CreateDirectory();
        }

        private void CreateDirectory()
        {
            Directory.CreateDirectory($"NOTES/{Name}");
        }

        public Course GetCourseData()
        {
            return new Course
            {
                CourseName = Name,
                PortalCourseId = Id,
                DateAdded = DateTime.Now,
                UserId = UserId
            };
        }

        #region VARIABLE DECLARATION

        public int Id { get; set; }
        public string Name { get; set; }
        private int UserId { get; }

        #endregion VARIABLE DECLARATION
    }
}