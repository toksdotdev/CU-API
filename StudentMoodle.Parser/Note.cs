using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMoodle.Parser
{
    public class Note
    {
        public int noteId { get; set; }
        public int portalNoteId { get; set; }
        public int courseId { get; set; }
        public string noteName { get; set; }
        public string noteCustomPath { get; set; }
        public DateTime? dateDownloaded { get; set; }

        public virtual Course Cours { get; set; }
    }
}