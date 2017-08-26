using System;
using System.Collections.Generic;

namespace StudentMoodle.Parser
{
    public sealed class Course
    {
        public int CourseId { get; set; }
        public int PortalCourseId { get; set; }
        public int UserId { get; set; }
        public string CourseName { get; set; }
        public DateTime? DateAdded { get; set; }

        public ICollection<Note> Notes { get; set; } = new HashSet<Note>();
    }
}