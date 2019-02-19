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

        #region winform_functions
        int total = 0;

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
            int online = 0;
            int offline = 0;

            // initialize data
            buddyTreeView.Invoke(new MethodInvoker(delegate
            {
                buddyTreeView.Nodes[0].Text = "Online 0/" + total.ToString();
                buddyTreeView.Nodes[1].Text = "Offline 0/" + total.ToString();
            }));

            while (true)
            {
                if (!chat.irc.IsClientRunning())
                    continue;

                total = chat.buddyStatus.Count();

                foreach (KeyValuePair<string, bool> kvp in chat.buddyStatus.ToList())
                {
                    chat.irc.SendRawMessage("whois " + kvp.Key); // send whois command, this will populate the buddyStatus dictionary
                    buddyTreeView.Invoke(new MethodInvoker(delegate
                    {
                        if (kvp.Value == true)
                        {
                            //Debug.WriteLine("[BUD] " + kvp.Key + " is online");
                            TreeNode[] nodes = buddyTreeView.Nodes[1].Nodes.Find(kvp.Key, true);
                            if (nodes.Length > 0)
                            {
                                buddyTreeView.Nodes.Remove(nodes[0]);
                                offline--;
                            }
                            TreeNode[] nodes2 = buddyTreeView.Nodes[0].Nodes.Find(kvp.Key, true);
                            if (nodes2.Length <= 0)
                            {
                                TreeNode ntn = new TreeNode();
                                ntn.Text = kvp.Key;
                                ntn.Name = kvp.Key;
                                ntn.Tag = kvp.Key;
                                buddyTreeView.Nodes[0].Nodes.Add(ntn);
                                online++;
                                buddyTreeView.Nodes[0].Expand();
                            }
                        }
                        else
                        {
                            //Debug.WriteLine("[BUD] " + kvp.Key + " is offline");
                            TreeNode[] nodes = buddyTreeView.Nodes[0].Nodes.Find(kvp.Key, true);
                            if (nodes.Length > 0)
                            {
                                buddyTreeView.Nodes.Remove(nodes[0]);
                                online--;
                            }
                            TreeNode[] nodes2 = buddyTreeView.Nodes[1].Nodes.Find(kvp.Key, true);
                            if (nodes2.Length <= 0)
                            {
                                TreeNode ntn = new TreeNode();
                                ntn.Text = kvp.Key;
                                ntn.Name = kvp.Key;
                                ntn.Tag = kvp.Key;
                                buddyTreeView.Nodes[1].Nodes.Add(ntn);
                                offline++;
                                buddyTreeView.Nodes[1].Expand();
                            }
                        }
                        buddyTreeView.Nodes[0].Text = "Online " + online.ToString() + "/" + total.ToString();
                        buddyTreeView.Nodes[1].Text = "Offline " + offline.ToString() + "/" + total.ToString();
                    }));

                    Thread.Sleep(1000);
                }

                Thread.Sleep(5000);
                
            }
        }

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buddyTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (buddyTreeView.SelectedNode.Text == null)
                return;
            if (!chat.buddyStatus.ContainsKey(buddyTreeView.SelectedNode.Text))
                return;
            if (chat.buddyStatus[buddyTreeView.SelectedNode.Text] == true) // have to be online to IM
            {
                instant_message im = new instant_message(buddyTreeView.SelectedNode.Text);
                im.Owner = this;
                im.MdiParent = MdiParent;
                im.Tag = buddyTreeView.SelectedNode.Text;
                im.Show();
            }
        }

        private void IMBtn_Click(object sender, EventArgs e)
        {
            if (buddyTreeView.SelectedNode.Text == null)
                return;
            if (!chat.buddyStatus.ContainsKey(buddyTreeView.SelectedNode.Text))
                return;
            if (chat.buddyStatus[buddyTreeView.SelectedNode.Text] == true) // have to be online to IM
            {
                instant_message im = new instant_message(buddyTreeView.SelectedNode.Text);
                im.Owner = this;
                im.MdiParent = MdiParent;
                im.Tag = buddyTreeView.SelectedNode.Text;
                im.Show();
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
            foreach (string b in accounts.getBuddyList())
            {
                chat.buddyStatus.Add(b, false); // offline by default
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
