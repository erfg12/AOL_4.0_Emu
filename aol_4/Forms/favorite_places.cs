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
    public partial class favorite_places : Form
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

        void maxiMini()
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

        int wndX = 0;
        int wndY = 0;
        int wndWidth = 0;

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            maxiMini();
        }

        private void FpTreeView_DoubleClick(object sender, EventArgs e)
        {
            goToURL();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            goToURL();
        }

        private void goToURL()
        {
            if (fpTreeView.SelectedNode == null)
                return;
            if (fpTreeView.SelectedNode.Text == null)
                return;
            if (fpTreeView.SelectedNode.Tag == null)
                return;

            Form BrowseWnd = new Browse(fpTreeView.SelectedNode.Tag.ToString());
            BrowseWnd.Owner = (Form)MdiParent;
            BrowseWnd.MdiParent = MdiParent;
            BrowseWnd.Show();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            add_favorite af = new add_favorite("", "");
            af.Owner = this;
            af.MdiParent = MdiParent;
            af.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (fpTreeView.SelectedNode == null)
                return;
            if (fpTreeView.SelectedNode.Text == null)
                return;
            if (fpTreeView.SelectedNode.Tag == null)
                return;

            sqlite_accounts.deleteFavorite(fpTreeView.SelectedNode.Tag.ToString());
            fpTreeView.SelectedNode.Remove();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (fpTreeView.SelectedNode == null)
                return;
            if (fpTreeView.SelectedNode.Text == null)
                return;
            if (fpTreeView.SelectedNode.Tag == null)
                return;

            add_favorite af = new add_favorite(fpTreeView.SelectedNode.Tag.ToString(), fpTreeView.SelectedNode.Text, true);
            af.Owner = this;
            af.MdiParent = MdiParent;
            af.Show();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // check for new favorite items
                foreach (KeyValuePair<string, string> t in sqlite_accounts.getFavoritesList())
                {
                    if (!fpTreeView.Nodes[0].Nodes.ContainsKey(t.Key))
                        reloadFavorites();
                }
                Thread.Sleep(1000);
            }
        }

        private void reloadFavorites()
        {
            fpTreeView.Invoke(new MethodInvoker(delegate
            {
                fpTreeView.Nodes[0].Nodes.Clear();

                foreach (KeyValuePair<string, string> t in sqlite_accounts.getFavoritesList())
                {
                    TreeNode ntn = new TreeNode();
                    ntn.Text = t.Value;
                    ntn.Name = t.Key;
                    ntn.Tag = t.Key;
                    fpTreeView.Nodes[0].Nodes.Add(ntn);
                    fpTreeView.Nodes[0].Expand();
                }
            }));
        }

        int wndHeight = 0;

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = PointToClient(Cursor.Position);

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

        public bool maximized = false;

        #endregion

        private void Favorite_places_Shown(object sender, EventArgs e)
        {
            reloadFavorites();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        public favorite_places()
        {
            InitializeComponent();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
