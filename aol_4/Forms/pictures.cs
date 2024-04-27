using System;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class pictures : Win95Theme
    {
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }


        public pictures()
        {
            InitializeComponent();
        }

        private void Pictures_Load(object sender, EventArgs e)
        {

        }
    }
}
