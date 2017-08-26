using System;

namespace StudentMoodle.Parser
{
    public class Note
    {
        public int NoteId { get; set; }
        public int PortalNoteId { get; set; }
        public int CourseId { get; set; }
        public string NoteName { get; set; }
        public string NoteCustomPath { get; set; }
        public DateTime? DateDownloaded { get; set; }

        public virtual Course Cours { get; set; }
    }
}