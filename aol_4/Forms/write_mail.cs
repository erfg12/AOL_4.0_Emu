using aol.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace aol.Forms
{
    public partial class write_mail : Form
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

        int wndX = 0;
        int wndY = 0;
        int wndWidth = 0;
        int wndHeight = 0;
        public bool maximized = false;

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
                this.Location = new Point(0, 106);
                this.Width = Parent.Width - 4;
                this.Height = Parent.Height - 110;
            }
        }
        #endregion

        #region my_functions
        // key = name, value = address
        private Dictionary<string, string> parseSendTo(string parse)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            string[] replaceThese = new string[] { "<", ">", "\"" };

            if (parse.Contains(";"))
            {
                string[] eachAddr = parse.Split(';');

                foreach (string addr in eachAddr)
                {
                    if (addr == "")
                        continue;

                    if (addr.Contains("<"))
                    {
                        string[] info = addr.Split('<');
                        string cleanName = info[0];
                        string cleanAddr = info[1];

                        foreach (string r in replaceThese)
                        {
                            cleanName = cleanName.Replace(r, "").Trim();
                            cleanAddr = cleanAddr.Replace(r, "").Trim();
                            Debug.WriteLine("[MAIL] replacing " + r);
                        }
                        Debug.WriteLine("[MAIL] Adding 0:" + cleanName + " 1:" + cleanAddr);
                        if (!list.ContainsKey(cleanName))
                            list.Add(cleanName, cleanAddr);
                    }
                    else
                    {
                        list.Add("", addr);
                    }
                }
            }
            else
            {
                list.Add("", parse);
            }

            return list;
        }

        public write_mail(string sendTo = "", string subject = "")
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            Dock = DockStyle.Fill;

            sendToBox.Text = sendTo;
            subjectBox.Text = subject;
        }
        #endregion

        #region winform_functions
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            maxiMini();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void sendButton_Click(object sender, EventArgs e)
        {
            // parse <name> "address"; format
            foreach (KeyValuePair<string, string> entry in parseSendTo(sendToBox.Text))
            {
                email.sendEmail(entry.Key, entry.Value, subjectBox.Text, messageBox.Text);
            }
            MessageBox.Show("Your email has been sent!");
            Close();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            maxiMini();
        }

        private void write_mail_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
