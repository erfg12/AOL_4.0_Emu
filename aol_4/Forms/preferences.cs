using System;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class preferences : Win95Theme
    {
        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void GeneralBtn_Click(object sender, EventArgs e)
        {
            settings sf = new settings();
            sf.Owner = (Form)this;
            sf.MdiParent = MdiParent;
            sf.Show();
        }

        public preferences()
        {
            InitializeComponent();
        }
    }
}
