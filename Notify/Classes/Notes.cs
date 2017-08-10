using Notify.Models;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Notify.Classes
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

        public void DownloadNotes(WebBrowser browser)
        {
            //this.browser = browser;
            //browser.Navigate("http://10.0.3.32/mod/resource/view.php?id=16225");

            var downloader = new Downloader.DownloadFile(
                $"{Host}{ResourcesLinkTemplate}{CourseId}",
                "Notes/file1",
                DownloadCompleteCallback);

            downloader.DownloadNow();
        }

        private void DownloadCompleteCallback(object sender, DownloadDataCompletedEventArgs e)
        {
            MessageBox.Show($"Finished Downloading Notes for {CourseId}");
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