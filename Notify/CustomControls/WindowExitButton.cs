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
            private get { return _bgColor; }
            set
            {
                _bgColor = value;
                CloseOvalShape.FillColor = value;
                CloseOvalShape.BorderColor = value;
                CloseOvalShape.SelectionColor = Color.Transparent;
                panel1.BackColor = value;
            }
        }

        //public Color PillBackColor
        //{
        //    get
        //    {
        //        return CloseOvalShape.FillColor;
        //    }
        //    set
        //    {
        //        _pillBackColor = value;
        //        pillLabel.BackColor = _pillBackColor;
        //        rectangleShape1.FillColor = _pillBackColor;
        //    }
        //}

        public new EventHandler Click
        {
            get { return null; }
            set
            {
                CloseOvalShape.Click += value;
                panel1.Click += value;
                shapeContainer1.Click += value;
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