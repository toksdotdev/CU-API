using System;
using System.IO;
using System.Net;

#pragma warning disable CS0234 // The type or namespace name 'Forms' does not exist in the namespace 'System.Windows' (are you missing an assembly reference?)

using System.Windows.Forms;

#pragma warning restore CS0234 // The type or namespace name 'Forms' does not exist in the namespace 'System.Windows' (are you missing an assembly reference?)

namespace StudentMoodle
{
    internal class Notes
    {
        #region VARIABLE DECLARATION

        private const string ResourcesLinkTemplate = "/mod/resource/view.php?id=";

        private const string Host = "http://10.0.3.32";

        private int CourseId { get; set; }
        private string NoteName { get; set; }

        #endregion VARIABLE DECLARATION

        public Notes(int courseId, int noteId)
        {
            CourseId = courseId;
            courseId = noteId;
        }

#pragma warning disable CS0246 // The type or namespace name 'WebBrowser' could not be found (are you missing a using directive or an assembly reference?)

        public void DownloadNotes(WebBrowser browser)
#pragma warning restore CS0246 // The type or namespace name 'WebBrowser' could not be found (are you missing a using directive or an assembly reference?)
        {
            //this.browser = browser;
            //browser.Navigate("http://10.0.3.32/mod/resource/view.php?id=16225");

            FileDownloader.Download($"{Host}{ResourcesLinkTemplate}{CourseId}", "Notes/file1");
        }

        public void WriteNoteDataToDb()
        {
            using (var db = new NotifyLocalDBEntities())
            {
                db.Notes.Add(new Note
                {
                    portalNoteId = CourseId,
                    courseId = CourseId,
                    noteName = new Random().Next().ToString() + DateTime.Now,
                    dateDownloaded = DateTime.Now,
                    //complete it later
                });
            }
        }

        public void RenameNote()
        {
            if (File.Exists(NoteName))
            {
                //file k =new FileInfo(NoteName);
                //k.
            }
        }
    }
}