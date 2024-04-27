using aol.Classes;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class read_mail : Win95Theme
    {

        string EmailID = "";

        #region my_functions
        public read_mail(string subject, string emailID)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            Dock = DockStyle.Fill;

            EmailID = emailID;
            Text = subject;
            mainTitle.Text = subject;
            string tmpString = email.readEmail(EmailID);
            mailViewer.DocumentText = tmpString;
            if (tmpString.Contains("msg NickServ"))
            {
                Debug.WriteLine("Found NickServ code for IRC chatrooms.");
                registerNickserv(tmpString);
            }
        }

        public void registerNickserv(string m)
        {
            var match = Regex.Match(m, "NickServ CONFIRM (.*?) \"", RegexOptions.Singleline);
            string register = match.Groups[1].Value;
            Debug.WriteLine("nickserv code = \"" + register + "\"");
            chat.irc.SendMessageToChannel("CONFIRM " + register, "NickServ");
            MessageBox.Show("Your username has been registered successfully! You can now access restricted chatrooms!");
        }
        #endregion

        #region winform_functions
        private void read_mail_Shown(object sender, EventArgs e)
        {

        }

        private void replyButton_Click(object sender, EventArgs e)
        {
            write_mail wmf = new write_mail(email.reply, "Re:" + Text);
            wmf.Owner = this;
            wmf.MdiParent = MdiParent;
            wmf.Show();
        }

        private void read_mail_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            maxiMini(maxBtn);
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            maxiMini(maxBtn);
        }
        #endregion
    }
}
