using aol.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherNet;

namespace aol.Forms
{
    public partial class home_menu : Form
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

        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        new Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
            e.Graphics.FillRectangle(Brushes.Gray, Top);
            e.Graphics.FillRectangle(Brushes.Gray, Left);
            e.Graphics.FillRectangle(Brushes.Gray, Right);
            e.Graphics.FillRectangle(Brushes.Gray, Bottom);

            /*Graphics g = e.Graphics;
            foreach (Rectangle rect in rects)
            {
                Pen pen = new Pen(Color.Black, 5);
                //pen.Alignment = PenAlignment.Inset;
                g.DrawRectangle(pen, rect);
            }*/
        }
        #endregion

        #region winform_functions
        List<Rectangle> rects = new List<Rectangle>();

        private void panel1_MouseClick(object sender, MouseEventArgs e)
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

        private void home_menu_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void home_menu_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void home_menu_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Rectangle r in rects)
            {
                if (r.Contains(e.Location)) {
                    Cursor = Cursors.Hand;
                    return;
                }
            }
            Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Rectangle r in rects)
            {
                if (r.Contains(e.Location) && rects.IndexOf(r) == 0) // mailbox
                {
                    mailbox mb = new mailbox();
                    mb.Owner = this;
                    mb.MdiParent = MdiParent;
                    mb.Show();
                }
                if (r.Contains(e.Location) && rects.IndexOf(r) == 1) // channels
                {
                    channels chan = new channels();
                    chan.Owner = this;
                    chan.MdiParent = MdiParent;
                    chan.Show();
                }
                if (r.Contains(e.Location) && rects.IndexOf(r) == 2) // chat_list
                {
                    chat_list cl = new chat_list();
                    cl.Owner = this;
                    cl.MdiParent = MdiParent;
                    cl.Show();
                }
                if (r.Contains(e.Location) && rects.IndexOf(r) == 3) // pictures
                {
                    pictures p = new pictures();
                    p.Owner = this;
                    p.MdiParent = MdiParent;
                    p.Show();
                }
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {

        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void StartForm()
        {
            todayLabel.Invoke(new MethodInvoker(delegate
            {
                todayLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            }));
            titleLabel.Invoke(new MethodInvoker(delegate
            {
                titleLabel.Text = "Welcome, " + accForm.tmpUsername;
            }));
            temperatureLabel.Invoke(new MethodInvoker(delegate
            {
                temperatureLabel.Text = location.getCurrentWeather();
            }));
        }

        private void home_menu_ShownAsync(object sender, EventArgs e)
        {
            location.PositionWindow(this);

            rects.Add(new Rectangle(5, 155, 175, 80)); // 0 mailbox
            rects.Add(new Rectangle(5, 335, 175, 80)); // 1 channels
            rects.Add(new Rectangle(5, 425, 175, 80)); // 2 chat_list
            rects.Add(new Rectangle(5, 250, 175, 80)); // 3 pictures

            Thread thr = new Thread(StartForm);
            thr.Start();
        }

        public home_menu()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }
        #endregion
    }
}
