using System;
using System.Windows.Forms;

namespace Notify
{
    public partial class Notify : Form
    {
        public Notify()
        {
            InitializeComponent();
        }

        private void CloseOvalShape_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}