using aol.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class mailbox : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        int wndX = 0;
        int wndY = 0;
        int wndWidth = 0;
        int wndHeight = 0;
        public bool maximized = false;

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

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

        public mailbox()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Dock = DockStyle.Fill;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miniMax()
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

            if (this.ActiveMdiChild != null)
            {
                bool resize = false;
                if (this.ActiveMdiChild is Browse && ((Browse)ActiveMdiChild).maximized)
                    resize = true;
                if (this.ActiveMdiChild is buddies_online && ((buddies_online)ActiveMdiChild).maximized)
                    resize = true;

                if (resize)
                {
                    this.ActiveMdiChild.Width = this.Width - 4;
                    this.ActiveMdiChild.Height = this.Height - 110;
                }
            }
        }

        private void maxiMini()
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            maxiMini();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            maxiMini();
        }

        private void mailbox_Load(object sender, EventArgs e)
        {

        }

        private void GetEmail()
        {
            email.getEmail();
            foreach (KeyValuePair<string, string> entry in email.emailsNew)
            {
                ListViewItem lIt = new ListViewItem();
                lIt.Tag = entry.Key;
                lIt.Text = entry.Value;
                //Debug.WriteLine("[MAIL] Adding NEW Key(tag):" + entry.Key + " Value(text):" + entry.Value);
                newListView.Invoke(new MethodInvoker(delegate { newListView.Items.Add(lIt); }));
            }
            foreach (KeyValuePair<string, string> entry in email.emailsOld)
            {
                ListViewItem lIt = new ListViewItem();
                lIt.Tag = entry.Key;
                lIt.Text = entry.Value;
                //Debug.WriteLine("[MAIL] Adding OLD Key(tag):" + entry.Key + " Value(text):" + entry.Value);
                oldListView.Invoke(new MethodInvoker(delegate { oldListView.Items.Add(lIt); }));
            }
            foreach (KeyValuePair<string, string> entry in email.emailsSent)
            {
                ListViewItem lIt = new ListViewItem();
                lIt.Tag = entry.Key;
                lIt.Text = entry.Value;
                //Debug.WriteLine("[MAIL] Adding SENT Key(tag):" + entry.Key + " Value(text):" + entry.Value);
                sentListView.Invoke(new MethodInvoker(delegate { sentListView.Items.Add(lIt); }));
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (newListView.Visible)
            {
                email.deleteEmail(newListView.SelectedItems[0].Tag.ToString());
                newListView.Items.RemoveAt(newListView.SelectedItems[0].Index);
                Debug.WriteLine("[MAIL] new mail count: " + newListView.Items.Count + " YGM flag: " + email.youGotMail);
                if (newListView.Items.Count == 0)
                    email.youGotMail = false;
            }
            else if (oldListView.Visible)
            {
                email.deleteEmail(oldListView.SelectedItems[0].Tag.ToString());
                oldListView.Items.RemoveAt(oldListView.SelectedItems[0].Index);
            }
            else if (sentListView.Visible)
            {
                email.deleteEmail(sentListView.SelectedItems[0].Tag.ToString());
                sentListView.Items.RemoveAt(sentListView.SelectedItems[0].Index);
            }
            MessageBox.Show("Email has been deleted.");
        }

        private void mailbox_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(GetEmail));
            thread.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openReadEmail(string subject, string emailID)
        {
            read_mail rmf = new read_mail(subject, emailID);
            rmf.Owner = this;
            rmf.MdiParent = MdiParent;
            rmf.Show();
        }

        private void newListview_DoubleClick(object sender, EventArgs e)
        {
            email.markAsSeen(newListView.SelectedItems[0].Tag.ToString());
            openReadEmail(newListView.SelectedItems[0].Text, newListView.SelectedItems[0].Tag.ToString());
            ListViewItem lIt = new ListViewItem();
            lIt.Tag = newListView.SelectedItems[0].Tag.ToString();
            lIt.Text = newListView.SelectedItems[0].Text;
            oldListView.Items.Add(lIt);
            newListView.Items.RemoveAt(newListView.SelectedItems[0].Index);
            if (newListView.Items.Count == 0)
                email.youGotMail = false;
        }

        private void oldListView_DoubleClick(object sender, EventArgs e)
        {
            openReadEmail(oldListView.SelectedItems[0].Text, oldListView.SelectedItems[0].Tag.ToString());
        }

        private void sentListView_DoubleClick(object sender, EventArgs e)
        {
            openReadEmail(sentListView.SelectedItems[0].Text, sentListView.SelectedItems[0].Tag.ToString());
        }
    }
}
