using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notify.CustomControls
{
    public sealed partial class WindowExitButton : UserControl
    {
        private Color _bgColor;

        public new Color BackColor
        {
            get { return _bgColor; }
            set
            {
                //_bgColor = value;
                ////CloseOvalShape.BackColor = value;
                //panel1.BackColor = value;
                //this.BackColor = value;
            }
        }

        public WindowExitButton()
        {
            InitializeComponent();
            BackColor = (BackColor.IsEmpty) ? Color.Red : BackColor;
            panel1.BringToFront();
        }

        private void WindowExitButton_Enter(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void WindowExitButton_Leave(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.BringToFront();
        }
    }
}