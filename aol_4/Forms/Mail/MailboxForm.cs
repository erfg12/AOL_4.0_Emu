using aol.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class MailboxForm : Win95Theme
    {
        public MailboxForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Dock = DockStyle.Fill;
        }

        private void GetEmail()
        {
            MailService.getEmail();
            foreach (KeyValuePair<string, string> entry in MailService.emailsNew)
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
            foreach (KeyValuePair<string, string> entry in MailService.emailsOld)
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
            foreach (KeyValuePair<string, string> entry in MailService.emailsSent)
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

            MailService.markAsSeen(newListView.SelectedItems[0].Tag.ToString());
            ListViewItem lIt = new ListViewItem();
            lIt.Tag = newListView.SelectedItems[0].Tag.ToString();
            lIt.Text = newListView.SelectedItems[0].Text;
            oldListView.Items.Add(lIt);
            newListView.Items.RemoveAt(newListView.SelectedItems[0].Index);
            if (newListView.Items.Count == 0)
                MailService.youGotMail = false;
        }

        private void openReadEmail(string subject, string emailID)
        {
            MailReadForm rmf = new MailReadForm(subject, emailID);
            rmf.Owner = this;
            rmf.MdiParent = MdiParent;
            rmf.Show();
        }

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
            maxiMini(maxBtn);
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            maxiMini(maxBtn);
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

                MailService.deleteEmail(newListView.SelectedItems[0].Tag.ToString());
                newListView.Items.RemoveAt(newListView.SelectedItems[0].Index);
                Debug.WriteLine("[MAIL] new mail count: " + newListView.Items.Count + " YGM flag: " + MailService.youGotMail);
                if (newListView.Items.Count == 0)
                    MailService.youGotMail = false;
            }
            else if (oldListView.Visible)
            {
                if (oldListView.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MailService.deleteEmail(oldListView.SelectedItems[0].Tag.ToString());
                oldListView.Items.RemoveAt(oldListView.SelectedItems[0].Index);
            }
            else if (sentListView.Visible)
            {
                if (sentListView.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("Select an email first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MailService.deleteEmail(sentListView.SelectedItems[0].Tag.ToString());
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
                MailService.markAsUnseen(oldListView.SelectedItems[0].Tag.ToString());
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
            LocationService.PositionWindow(this, 0, 55);
            Thread thread = new Thread(new ThreadStart(GetEmail));
            thread.Start();
            Text = Account.tmpUsername + "'s Online Mailbox";
            mainTitle.Text = Account.tmpUsername + "'s Online Mailbox";
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
    }
}
