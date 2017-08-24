using System;
using System.Diagnostics;
using System.Net;

namespace StudentMoodle
{
    public class FileDownloader : Downloader
    {
        public static void Download(string downloadUrl, string filename, DownloadDataCompletedEventHandler callbackDelegate)
        {
            try
            {
                URLDownloadToFile(0, downloadUrl, filename, 0, 0);
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.Message);
            }
        }
    }
}