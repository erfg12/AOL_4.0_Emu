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
        #region DllImports
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        #endregion

        #region win95_theme
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

        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        new Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

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
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
            e.Graphics.FillRectangle(Brushes.Gray, Top);
            e.Graphics.FillRectangle(Brushes.Gray, Left);
            e.Graphics.FillRectangle(Brushes.Gray, Right);
            e.Graphics.FillRectangle(Brushes.Gray, Bottom);
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
                maxBtn.Image = Properties.Resources.maximize_btn;
            }
            else
            {
                wndX = this.Location.X;
                wndY = this.Location.Y;
                wndWidth = this.Width;
                wndHeight = this.Height;
                maximized = true;
                this.Location = new Point(0, 106);
                this.Width = Parent.Width - 4;
                this.Height = Parent.Height - 110;
                maxBtn.Image = Properties.Resources.restore_btn;
            }
        }
        #endregion

        #region my_functions
        public mailbox()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Dock = DockStyle.Fill;
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
                try
                {
                    newListView.Invoke(new MethodInvoker(delegate { newListView.Items.Add(lIt); }));
                } catch
                {
                    Debug.WriteLine("Prevented a crash from closing mailbox before we could load the items in.");
                }
            }
            foreach (KeyValuePair<string, string> entry in email.emailsOld)
            {
                ListViewItem lIt = new ListViewItem();
                lIt.Tag = entry.Key;
                lIt.Text = entry.Value;
                //Debug.WriteLine("[MAIL] Adding OLD Key(tag):" + entry.Key + " Value(text):" + entry.Value);
                try
                {
                    oldListView.Invoke(new MethodInvoker(delegate { oldListView.Items.Add(lIt); }));
                } catch
                {

                }
            }
            foreach (KeyValuePair<string, string> entry in email.emailsSent)
            {
                ListViewItem lIt = new ListViewItem();
                lIt.Tag = entry.Key;
                lIt.Text = entry.Value;
                //Debug.WriteLine("[MAIL] Adding SENT Key(tag):" + entry.Key + " Value(text):" + entry.Value);
                try
                {
                    sentListView.Invoke(new MethodInvoker(delegate { sentListView.Items.Add(lIt); }));
                } catch { }
            }
        }

        void moveToOld()
        {
            if (newListView.SelectedItems.Count <= 0)
                return;

            email.markAsSeen(newListView.SelectedItems[0].Tag.ToString());
            ListViewItem lIt = new ListViewItem();
            lIt.Tag = newListView.SelectedItems[0].Tag.ToString();
            lIt.Text = newListView.SelectedItems[0].Text;
            oldListView.Items.Add(lIt);
            newListView.Items.RemoveAt(newListView.SelectedItems[0].Index);
            if (newListView.Items.Count == 0)
                email.youGotMail = false;
        }

        private void openReadEmail(string subject, string emailID)
        {
            read_mail rmf = new read_mail(subject, emailID);
            rmf.Owner = this;
            rmf.MdiParent = MdiParent;
            rmf.Show();
        }
        #endregion

        #region winform_functions
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (newListView.Visible)
            {
                if (newListView.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                email.deleteEmail(newListView.SelectedItems[0].Tag.ToString());
                newListView.Items.RemoveAt(newListView.SelectedItems[0].Index);
                Debug.WriteLine("[MAIL] new mail count: " + newListView.Items.Count + " YGM flag: " + email.youGotMail);
                if (newListView.Items.Count == 0)
                    email.youGotMail = false;
            }
            else if (oldListView.Visible)
            {
                if (oldListView.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                email.deleteEmail(oldListView.SelectedItems[0].Tag.ToString());
                oldListView.Items.RemoveAt(oldListView.SelectedItems[0].Index);
            }
            else if (sentListView.Visible)
            {
                if (sentListView.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                email.deleteEmail(sentListView.SelectedItems[0].Tag.ToString());
                sentListView.Items.RemoveAt(sentListView.SelectedItems[0].Index);
            }
            MessageBox.Show("Email has been deleted.");
        }

        private void keepBtn_Click(object sender, EventArgs e)
        {
            if (oldListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (oldListView.Visible) // only works on old emails
            {
                email.markAsUnseen(oldListView.SelectedItems[0].Tag.ToString());
                ListViewItem lIt = new ListViewItem();
                lIt.Tag = oldListView.SelectedItems[0].Tag.ToString();
                lIt.Text = oldListView.SelectedItems[0].Text;
                newListView.Items.Add(lIt);
                oldListView.Items.RemoveAt(oldListView.SelectedItems[0].Index);
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            if (newListView.Visible && newListView.SelectedItems.Count > 0)
            {
                openReadEmail(newListView.SelectedItems[0].Text, newListView.SelectedItems[0].Tag.ToString());
                moveToOld();
            }
            else if (newListView.Visible && newListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (oldListView.Visible && oldListView.SelectedItems.Count > 0)
                openReadEmail(oldListView.SelectedItems[0].Text, oldListView.SelectedItems[0].Tag.ToString());
            else if (oldListView.Visible && oldListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sentListView.Visible && sentListView.SelectedItems.Count > 0)
                openReadEmail(sentListView.SelectedItems[0].Text, sentListView.SelectedItems[0].Tag.ToString());
            else if (sentListView.Visible && sentListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mailbox_Shown(object sender, EventArgs e)
        {
            location.PositionWindow(this, 0, 55);
            Thread thread = new Thread(new ThreadStart(GetEmail));
            thread.Start();
            Text = accForm.tmpUsername + "'s Online Mailbox";
            mainTitle.Text = accForm.tmpUsername + "'s Online Mailbox";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newListview_DoubleClick(object sender, EventArgs e)
        {
            if (newListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            openReadEmail(newListView.SelectedItems[0].Text, newListView.SelectedItems[0].Tag.ToString());
            moveToOld();
        }

        private void oldListView_DoubleClick(object sender, EventArgs e)
        {
            if (oldListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            openReadEmail(oldListView.SelectedItems[0].Text, oldListView.SelectedItems[0].Tag.ToString());
        }

        private void sentListView_DoubleClick(object sender, EventArgs e)
        {
            if (sentListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            openReadEmail(sentListView.SelectedItems[0].Text, sentListView.SelectedItems[0].Tag.ToString());
        }
        #endregion
    }
}
