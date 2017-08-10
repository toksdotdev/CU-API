using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notify.CustomControls
{
    public partial class PillControl : UserControl
    {
        public new EventHandler Click
        {
            get { return null; }
            set
            {
                panel4.Click += value;
                pillLabel.Click += value;
                rectangleShape1.Click += value;
            }
        }

        /// <returns>The text associated with this control.</returns>
        public override string Text
        {
            get
            {
                return pillLabel.Text;
            }
            set
            {
                pillLabel.Text = value;
            }
        }

        private Color _TempBackColor;

        private Color _pillBackColor;

        private Color _tempBackColor;

        public Color PillBackColor
        {
            get
            {
                return rectangleShape1.FillColor;
            }
            set
            {
                _pillBackColor = value;
                pillLabel.BackColor = _pillBackColor;
                rectangleShape1.FillColor = _pillBackColor;
            }
        }

        public PillControl()
        {
            InitializeComponent();
        }

        private void PillControl_Resize(object sender, EventArgs e)
        {
            var size = ((PillControl)sender).Size;
            rectangleShape1.Size = new Size(size.Width - 4, size.Height - 4);
        }

        private void PillControl_Click(object sender, EventArgs e)
        {
            //LoadCourseNotes
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            _tempBackColor = PillBackColor;

            PillBackColor = Color.DarkSlateGray;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            PillBackColor = _tempBackColor;
        }
    }
}