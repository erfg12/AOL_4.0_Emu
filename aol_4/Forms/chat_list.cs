using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class chat_list : Form
    {
        #region DLLImports
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        #endregion

        #region win95_theme
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private const int cGrip = 16;
        private const int cCaption = 32;

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        int wndX = 0;
        int wndY = 0;
        int wndWidth = 0;
        int wndHeight = 0;
        public bool maximized = false;

        void maxiMini()
        {
            if (maximized)
            {
                this.Location = new Point(wndX, wndY);
                this.Width = wndWidth;
                this.Height = wndHeight;
                maximized = false;
            }
            else
            {
                wndX = this.Location.X;
                wndY = this.Location.Y;
                wndWidth = this.Width;
                wndHeight = this.Height;
                maximized = true;
                this.Location = new Point(0, 101);
                this.Width = Parent.Width - 4;
                this.Height = Parent.Height - 105;
            }
        }

        const int _ = 2;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }

        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }

        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, Top);
            e.Graphics.FillRectangle(Brushes.Gray, Left);
            e.Graphics.FillRectangle(Brushes.Gray, Right);
            e.Graphics.FillRectangle(Brushes.Gray, Bottom);
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            maxiMini();
        }
        #endregion

        #region variables
        private Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>();
        //private Dictionary<string, string> channels = new Dictionary<string, string>();
        #endregion

        #region my_functions
        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

        private void getChannels()
        {
            using (WebClient client = new WebClient())
            {
                string content = client.DownloadString("https://snoonet.org/communities");
                foreach (Match m in Regex.Matches(content, "<h1 id=\"(.*?)<hr>", RegexOptions.Singleline))
                {
                    string catTitle = StripHTML(Regex.Match(m.Value, "<h1 id=\"(.*?)</h1>").Groups[0].Value);
                    if (catTitle == "Communities of Snoonet")
                        continue;

                    List<string> tmpChanList = new List<string>();
                    ListViewItem lIt = new ListViewItem();
                    lIt.Text = catTitle;
                    catListView.Invoke(new MethodInvoker(delegate { catListView.Items.Add(lIt); }));
                    // add channels
                    foreach (Match m2 in Regex.Matches(m.Value, "<a href=\"(.*?)</a>", RegexOptions.Singleline))
                    {
                        string chanHashtag = Regex.Match(m2.Value, "\">(.*?)</a>").Groups[1].Value;
                        if (!chanHashtag.Contains("#"))
                            continue;
                        if (chanHashtag == "#top")
                            continue;
                        tmpChanList.Add(chanHashtag);
                    }
                    // add category name with channel list to associate with channels dictionary
                    categories.Add(catTitle, tmpChanList);
                }
            }
        }
        #endregion

        #region winform_functions
        public chat_list()
        {
            InitializeComponent();
        }

        private void chanListView_DoubleClick(object sender, EventArgs e)
        {
            chatroom cr = new chatroom(chanListView.SelectedItems[0].Text.ToString());
            cr.Owner = this;
            cr.MdiParent = MdiParent;
            cr.Show();
        }

        private void chat_list_Shown(object sender, EventArgs e)
        {

        }

        private void catListView_MouseClick(object sender, MouseEventArgs e)
        {
            chanListView.Items.Clear();
            string key = catListView.SelectedItems[0].Text;
            foreach (string chan in categories[key])
            {
                ListViewItem lIt2 = new ListViewItem();
                lIt2.Tag = chan;
                lIt2.Text = chan.Replace("#","");
                chanListView.Items.Add(lIt2);
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void chat_list_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(getChannels));
            thread.Start();
        }
        #endregion
    }
}
