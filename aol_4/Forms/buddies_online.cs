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
    public partial class buddies_online : Form
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

        const int _ = 2;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        int wndX = 0;
        int wndY = 0;
        int wndWidth = 0;
        int wndHeight = 0;

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
                this.Location = new Point(0, 106);
                this.Width = Parent.Width - 4;
                this.Height = Parent.Height - 110;
            }
        }
        #endregion

        // key: name, value: online status
        Dictionary<string, bool> tmpBuddies = new Dictionary<string, bool>();
             
        #region winform_functions
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buddyListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // disable buddies label
            if (e.Index == 0)
                e.NewValue = e.CurrentValue;
        }

        private void setupBtn_Click(object sender, EventArgs e)
        {
            add_buddy ab = new add_buddy();
            ab.Owner = this;
            ab.MdiParent = MdiParent;
            ab.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
            while (true)
            {
                foreach(KeyValuePair<string, bool> kvp in tmpBuddies.ToList())
                {
                    chat.irc.SendRawMessage("whois " + kvp.Key);

                    while (chat.buddyOnline == "")
                    {
                        //Debug.WriteLine("[BUD] " + kvp.Key + " unknown status...");
                    }
                    buddyListView.Invoke(new MethodInvoker(delegate
                    {
                        if (chat.buddyOnline == "yes")
                        {
                            //Debug.WriteLine("[BUD] " + kvp.Key + " is online");
                            tmpBuddies[kvp.Key] = true;

                            TreeNode[] nodes = buddyTreeView.Nodes[1].Nodes.Find(kvp.Key, true);
                            if (nodes.Length > 0)
                                buddyTreeView.Nodes[1].Nodes.Remove(nodes[0]);
                            TreeNode[] nodes2 = buddyTreeView.Nodes[0].Nodes.Find(kvp.Key, true);
                            if (nodes2.Length <= 0)
                                buddyTreeView.Nodes[0].Nodes.Add(kvp.Key);

                            /*TreeNode node = buddyTreeView.Nodes[1].Nodes.Cast<TreeNode>().FirstOrDefault(x => x.Name == kvp.Key);
                            if (node != null)
                                buddyTreeView.Nodes[1].Nodes.Remove(node);
                            TreeNode node2 = buddyTreeView.Nodes[0].Nodes.Cast<TreeNode>().FirstOrDefault(x => x.Name == kvp.Key);
                            if (node2 == null)
                                buddyTreeView.Nodes[0].Nodes.Add(kvp.Key);*/

                            if (buddyListView.FindItemWithText("[OFF] " + kvp.Key) != null)
                                buddyListView.FindItemWithText("[OFF] " + kvp.Key).Text = "[ON] " + kvp.Key; // need both off and on
                            else
                                buddyListView.FindItemWithText("[ON] " + kvp.Key).Text = "[ON] " + kvp.Key;
                        }
                        else if (chat.buddyOnline == "no")
                        {
                            //Debug.WriteLine("[BUD] " + kvp.Key + " is offline");
                            TreeNode[] nodes = buddyTreeView.Nodes[0].Nodes.Find(kvp.Key, true);
                            if (nodes.Length > 0)
                                buddyTreeView.Nodes[0].Nodes.Remove(nodes[0]);
                            TreeNode[] nodes2 = buddyTreeView.Nodes[1].Nodes.Find(kvp.Key, true);
                            if (nodes2.Length <= 0)
                                buddyTreeView.Nodes[1].Nodes.Add(kvp.Key);

                            tmpBuddies[kvp.Key] = false;
                            /*TreeNode node = buddyTreeView.Nodes[0].Nodes.Cast<TreeNode>().FirstOrDefault(x => x.Name == kvp.Key);
                            if (node != null)
                                buddyTreeView.Nodes[0].Nodes.Remove(node);
                            TreeNode node2 = buddyTreeView.Nodes[1].Nodes.Cast<TreeNode>().FirstOrDefault(x => x.Name == kvp.Key);
                            if (node2 == null)
                                buddyTreeView.Nodes[1].Nodes.Add(kvp.Key);*/

                            if (buddyListView.FindItemWithText("[OFF] " + kvp.Key) != null)
                                buddyListView.FindItemWithText("[OFF] " + kvp.Key).Text = "[OFF] " + kvp.Key;
                            else
                                buddyListView.FindItemWithText("[ON] " + kvp.Key).Text = "[OFF] " + kvp.Key;
                        }
                    }));
                    //Debug.WriteLine("[BUD] " + kvp.Key + " Online:" + chat.buddyOnline);
                    chat.buddyOnline = ""; // reset

                    Thread.Sleep(1000);
                }
                Thread.Sleep(3000);
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maxiMini();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            maxiMini();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public buddies_online()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void buddies_online_Shown(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem();
            li.Text = "Buddies 0/0";
            buddyListView.Items.Add(li);
            foreach (string b in accounts.getBuddyList())
            {
                tmpBuddies.Add(b, false); // offline by default
                buddyListView.Items.Add("[OFF] " + b);
            }
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void buddies_online_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
