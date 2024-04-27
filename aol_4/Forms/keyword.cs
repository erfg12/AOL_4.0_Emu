using System;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class keyword : Win95Theme
    {
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public keyword()
        {
            InitializeComponent();
        }
    }
}
