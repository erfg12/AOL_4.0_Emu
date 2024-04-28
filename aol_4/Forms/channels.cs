using aol.Classes;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class channels : Win95Theme
    {
        #region winform_functions
        public void goToChannel (string channel, int width = 1105, int height = 650)
        {
            string title = $"{channel.ToTitleCase()} Channel";
            string path = Directory.GetCurrentDirectory() + @"\Channels\" + channel + ".htm";
            Debug.WriteLine(path);
            Form BrowseWnd = new Channel(path, title);
            BrowseWnd.Owner = this;
            BrowseWnd.MdiParent = MdiParent;
            BrowseWnd.Width = width + 6;
            BrowseWnd.Height = height + 26;
            BrowseWnd.Show();
        }
        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }

        private void channels_Shown(object sender, EventArgs e)
        {
            location.PositionWindow(this);
        }

        private void KidsOnlyBtn_Click(object sender, EventArgs e)
        {
            goToChannel("kids");
        }

        private void channels_Load(object sender, EventArgs e)
        {
            
        }

        public channels()
        {
            InitializeComponent();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }
        #endregion
    }
}
