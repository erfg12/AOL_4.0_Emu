using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class Win95Theme: Form
    {
        #region DLLImports
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        static extern int GetDpiForWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow(IntPtr hWnd);
        #endregion

        #region win95_theme
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int cGrip = 16;
        private const int cCaption = 32;
        int wndX = 0;
        int wndY = 0;
        int wndWidth = 0;
        int wndHeight = 0;
        public bool maximized = false;
        int paddingTop_100 = 117;
        int paddingTop_125 = 157;
        int paddingTop_150 = 195;
        int paddingTop_175 = 234;
        int paddingTop_200 = 250;
        int paddingTop_225 = 290;
        int paddingTop_250 = 320;
        int paddingTop_300 = 375;

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int widthHeight = 2;

        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, widthHeight); } }
        new Rectangle Left { get { return new Rectangle(0, 0, widthHeight, this.ClientSize.Height); } }
        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - widthHeight, this.ClientSize.Width, widthHeight); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - widthHeight, 0, widthHeight, this.ClientSize.Height); } }

        private bool resizeR, resizeD, resizeB = false;
        const int padding = 5;

        Rectangle TopLeft { get { return new Rectangle(0, 0, widthHeight, widthHeight); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - widthHeight, 0, widthHeight, widthHeight); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - widthHeight, widthHeight, widthHeight); } }
        //Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
        public Rectangle FormBottom { get { return new Rectangle(padding, this.ClientSize.Height - padding, this.ClientSize.Width - (padding * 2), padding); } }
        public Rectangle FormRight { get { return new Rectangle(this.ClientSize.Width - padding, padding, padding, this.ClientSize.Height - (padding * 2)); } }
        public Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - padding, this.ClientSize.Height - padding, padding, padding); } }

        protected override void WndProc(ref Message message)
        {
            if (!DesignMode)
            {
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
            base.WndProc(ref message);
        }

        // for main
        public void miniMax(Button maxBtn)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                maxBtn.BackgroundImage = Properties.Resources.maximize_btn;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                maxBtn.BackgroundImage = Properties.Resources.restore_btn;
            }

            ResizeMaximizedChildren();
        }

        public void ResizeMaximizedChildren()
        {
            if (this.ActiveMdiChild != null)
            {
                bool resize = false;
                if (this.ActiveMdiChild is BrowserForm && ((BrowserForm)ActiveMdiChild).maximized)
                    resize = true;
                //if (this.ActiveMdiChild is BuddyListForm && ((BuddyListForm)ActiveMdiChild).maximized)
                //    resize = true;

                if (resize)
                {
                    this.ActiveMdiChild.Width = this.Width - Convert.ToInt32(GetDisplayScaleFactor(this.Handle) * 3) - 2;
                    this.ActiveMdiChild.Height = this.Height - getTopPadding() - 5;
                }
            }
        }

        public void OpenMsgBox(string title, string message)
        {
            MsgBoxForm msgBox = new MsgBoxForm(title, message);
            Form MainForm = Application.OpenForms["MainForm"];
            msgBox.Owner = MainForm;
            msgBox.MdiParent = MainForm;
            msgBox.Location = new Point((MainForm.Width - msgBox.Width) / 2, (MainForm.Height - msgBox.Height) / 2);
            msgBox.Show();
        }

        /// <summary>
        /// Maximize or restore button
        /// </summary>
        /// <param name="maxBtn"></param>
        public void maxiMini(Button maxBtn)
        {
            if (maximized)
            {
                this.Location = new Point(wndX, wndY);
                this.Width = wndWidth;
                this.Height = wndHeight;
                maximized = false;
                maxBtn.BackgroundImage = Properties.Resources.maximize_btn;
            }
            else
            {
                wndX = this.Location.X;
                wndY = this.Location.Y;
                wndWidth = this.Width;
                wndHeight = this.Height;
                maximized = true;
                this.Location = new Point(0, 116);
                var t = GetDisplayScaleFactor(this.Handle);
                this.Width = Parent.Width - Convert.ToInt32(GetDisplayScaleFactor(this.Handle) * 3) - 2;
                this.Height = Parent.Height - getTopPadding() - 5;
                maxBtn.BackgroundImage = Properties.Resources.restore_btn;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!DesignMode)
            {
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
                e.Graphics.FillRectangle(Brushes.Gray, Top);
                e.Graphics.FillRectangle(Brushes.Gray, Left);
                e.Graphics.FillRectangle(Brushes.Gray, Right);
                e.Graphics.FillRectangle(Brushes.Gray, Bottom);
            }
        }

        public float GetDisplayScaleFactor(IntPtr windowHandle)
        {
            try
            {
                return GetDpiForWindow(windowHandle) / 96f;
            }
            catch
            {
                // Or fallback to GDI solutions above
                return 1;
            }
        }
        #endregion

        public Win95Theme()
        {
            InitializeComponent();
            //this.Move += WindowMoved;
        }

        private int getTopPadding()
        {
            var t = GetDisplayScaleFactor(this.Handle);
            int ret = paddingTop_100;
            if (t <= 1.00) ret = paddingTop_100;
            else if (t <= 1.25) ret = paddingTop_125;
            else if (t <= 1.50) ret = paddingTop_150;
            else if (t <= 1.75) ret = paddingTop_175;
            else if (t <= 2.00) ret = paddingTop_200;
            else if (t <= 2.25) ret = paddingTop_225;
            else if (t <= 2.50) ret = paddingTop_250;
            else if (t <= 3.00) ret = paddingTop_300;
            return Convert.ToInt32(ret);
        }

        public void OnLocationChanged(object sender,  EventArgs e)
        {
            if (this.Name != "main" && MdiParent != null) // prevent window from moving too high up
            {
                int paddingTopCalc = getTopPadding();
                if (this.Location.Y < paddingTopCalc)
                {
                    int LocX = this.Location.X;
                    this.Location = new Point(LocX, paddingTopCalc);
                }
            }
        }

        // allow moving a window if we're trying to drag it
        public void MoveWindow(object sender, MouseEventArgs e, Button maxBtn = null)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (maximized && maxBtn != null)
                    maxiMini(maxBtn);
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
