using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

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

        public void InitBrowser()
        {
            /*Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://www.google.com");
            browser.Dock = DockStyle.Fill;*/
            //browser.AddressChanged += Browser_AddressChanged;
            //toolStripContainer1.ContentPanel.Controls.Add(browser);
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miniMax()
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

            if (this.ActiveMdiChild is Browse)
            {
                if (((Browse)this.ActiveMdiChild).maximized)
                {
                    this.ActiveMdiChild.Width = this.Width - 4;
                    this.ActiveMdiChild.Height = this.Height - 121;
                }
            }
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            miniMax();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        const int tenDigit = 10; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, tenDigit); } }
        Rectangle Left { get { return new Rectangle(0, 0, tenDigit, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - tenDigit, this.ClientSize.Width, tenDigit); } }

        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - tenDigit, 0, tenDigit, this.ClientSize.Height); } }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
                ((Browse)this.ActiveMdiChild).browser.Forward();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
                ((Browse)this.ActiveMdiChild).browser.Back();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
                ((Browse)this.ActiveMdiChild).browser.Reload();
        }

        public static string address { get; set; }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.closeBtn, "Close Browser");
            toolTip1.SetToolTip(this.maxBtn, "Maximize Browser");
            toolTip1.SetToolTip(this.miniBtn, "Minimize Browser");
            toolTip1.SetToolTip(this.backBtn, "Back");
            toolTip1.SetToolTip(this.forwardBtn, "Forward");
            toolTip1.SetToolTip(this.reloadBtn, "Refresh");

            // open initial browser window
            openBrowser();
        }

        private void openBrowser()
        {
            Form BrowseWnd = new Browse(addrBox.Text);
            BrowseWnd.Owner = (Form)this;
            BrowseWnd.MdiParent = this;
            BrowseWnd.Show();
            BrowseWnd.Left += 100;
            BrowseWnd.Top += 120;
        }

        private Point FindLocation(Control ctrl)
        {
            if (ctrl.Parent is Form)
                return ctrl.Location;
            else
            {
                Point p = FindLocation(ctrl.Parent);
                p.X += ctrl.Location.X;
                p.Y += ctrl.Location.Y;
                return p;
            }
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            fileContextMenuStrip.Show(this.Location.X + 10, this.Location.Y + 40);
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool newWindow = false;

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {

        }

        string old_url = "";

        private void getMdiChildURL_Tick(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
            {
                if (((Browse)this.ActiveMdiChild).url != old_url)
                {
                    addrBox.Text = ((Browse)this.ActiveMdiChild).url;
                    old_url = addrBox.Text = ((Browse)this.ActiveMdiChild).url;
                }
            }
        }

        public void GoToURL()
        {
            if (this.ActiveMdiChild is Browse)
            {
                if (!newWindow)
                {
                    if (this.ActiveMdiChild is Browse)
                        ((Browse)this.ActiveMdiChild).goToUrl(addrBox.Text);
                }
                else
                {
                    openBrowser();
                    newWindow = false;
                }
            }
        }

        private void addrBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (addrBox.Text.Length <= 3)
                newWindow = true;

            if (e.KeyCode == Keys.Enter)
                GoToURL();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            GoToURL();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            SolidBrush brush1 = new SolidBrush(Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(102))))));
            if (e.Column == 13)
                e.Graphics.FillRectangle(brush1, e.CellBounds);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addrBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            
        }

        Rectangle TopLeft { get { return new Rectangle(0, 0, tenDigit, tenDigit); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - tenDigit, 0, tenDigit, tenDigit); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - tenDigit, tenDigit, tenDigit); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - tenDigit, this.ClientSize.Height - tenDigit, tenDigit, tenDigit); } }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
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

    protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            e.Graphics.FillRectangle(Brushes.Gray, Top);
            e.Graphics.FillRectangle(Brushes.Gray, Left);
            e.Graphics.FillRectangle(Brushes.Gray, Right);
            e.Graphics.FillRectangle(Brushes.Gray, Bottom);
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            miniMax();
        }
    }
}
