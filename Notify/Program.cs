using Notify.Classes;
using Notify.Forms;
using System;
using System.Windows.Forms;

namespace Notify
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
            //Application.Run(new Login());
        }
    }
}