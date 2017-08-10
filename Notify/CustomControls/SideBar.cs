using System.Windows.Forms;

namespace Notify
{
    public partial class SideBar : UserControl
    {
        private Button _navarBaseButton;

        public SideBar()
        {
            InitializeComponent();

            _navarBaseButton = navBarItemButton;
        }

        public void AddItem()
        {
        }
    }
}