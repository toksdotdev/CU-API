using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Notify.Classes
{
    internal class Downloader
    {
        #region VARIABLE DECLARATION

        private static DownloadDataCompletedEventHandler _callback;
        private static string _sDownloadUrl;
        private static string _sDownloadFile;

        #endregion VARIABLE DECLARATION

        [DllImport("URLMON.DLL", EntryPoint = "URLDownloadToFileW", SetLastError = true,
            CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern int URLDownloadToFile(int pCaller, string srcUrl,
            string dstFile, int reserved, int callBack);

        public class DownloadFile
        {
            public DownloadFile(string sUrl, string sFile, DownloadDataCompletedEventHandler callbackDelegate)
            {
                _callback = callbackDelegate;
                _sDownloadUrl = sUrl;
                _sDownloadFile = sFile;
            }

            public void DownloadNow()
            {
                URLDownloadToFile(0, _sDownloadUrl, _sDownloadFile, 0, 0);
            }
        }
    }
}