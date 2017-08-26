using System;

namespace StudentMoodle
{
    public class FileDownloader : Downloader
    {
        public static void Download(string downloadUrl, string filename)
        {
            try
            {
                URLDownloadToFile(0, downloadUrl, filename, 0, 0);
            }
            catch (Exception ex)
            {
                //Trace.TraceError(ex.Message);
            }
        }
    }
}