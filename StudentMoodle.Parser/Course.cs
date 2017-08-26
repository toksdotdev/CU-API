using System;
using System.Collections.Generic;

namespace StudentMoodle.Parser
{
    public sealed class Course
    {
        public int courseId { get; set; }
        public int portalCourseId { get; set; }
        public int userId { get; set; }
        public string courseName { get; set; }
        public DateTime? dateAdded { get; set; }

        public ICollection<Note> Notes { get; set; } = new HashSet<Note>();
    }
}