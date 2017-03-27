using Notify.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            this.CourseId = courseId;
            courseId = noteId;
        }

        public void DownloadNotes(WebBrowser browser)
        {
            //this.browser = browser;
            //browser.Navigate("http://10.0.3.32/mod/resource/view.php?id=16225");

            var downloader = new Downloader.DownloadFile(
                string.Format("{0}{1}{2}", Host, ResourcesLinkTemplate, CourseId),
                string.Format("Notes/file1"),
                DownloadCompleteCallback);

            downloader.DownloadNow();
        }

        private void DownloadCompleteCallback(object sender, DownloadDataCompletedEventArgs e)
        {
            MessageBox.Show(string.Format("Finished Downloading Notes for {0}", CourseId));
        }

        public void WriteNoteDataToDb()
        {
            using (var db = new NotifyLocalDBEntities())
            {
                db.Notes.Add(new Note()
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