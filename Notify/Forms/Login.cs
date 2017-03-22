using Notify.Classes;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Notify.Forms
{
    public partial class Login : Form
    {
        private TestingClass k = new TestingClass();

        public Login()
        {
            InitializeComponent();
            k.NavigatePage(new Uri("http://10.0.3.32"));

            k.Browser.DocumentCompleted += Browser_DocumentCompleted;

            this.Controls.Add(k.Browser);
            k.Browser.Show();
            k.Browser.Dock = DockStyle.Fill;
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k.NavigatePage(k.GetProfileLink());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k.GetCoursesData();
        }
    }
}