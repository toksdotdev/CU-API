using System.Runtime.InteropServices;

namespace StudentMoodle
{
    public class Downloader
    {
        [DllImport("URLMON.DLL", EntryPoint = "URLDownloadToFileW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        protected static extern int URLDownloadToFile(int pCaller, string srcUrl, string dstFile, int reserved, int callBack);
    }
}