using System;
using System.Windows.Forms;
using Notify.Forms;

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

            if (Properties.Settings.Default.LoggedIn)
            {
                Application.Run(new Dashboard());
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}