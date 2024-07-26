using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using aol.Classes;

namespace aol.Forms
{
    public partial class chat_list : Win95Theme
    {
        private void maxBtn_Click(object sender, EventArgs e)
        {

        }

        #region variables
        private ConcurrentDictionary<string, List<string>> categories = new ConcurrentDictionary<string, List<string>>();
        //private Dictionary<string, string> channels = new Dictionary<string, string>();
        #endregion

        #region my_functions
        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

        private void getChannels()
        {
            using (WebClient client = new WebClient())
            {
                string content = client.DownloadString("https://snoonet.org/community/");
                foreach (Match m in Regex.Matches(content, "<h2>(.*?)</table>", RegexOptions.Singleline))
                {
                    string catTitle = StripHTML(Regex.Match(m.Value, "<h2>(.*?)</h2>").Groups[0].Value);
                    if (catTitle == "Communities of Snoonet")
                        continue;

                    List<string> tmpChanList = new List<string>();
                    ListViewItem lIt = new ListViewItem();
                    lIt.Text = catTitle;
                    try
                    {
                        catListView.Invoke(new MethodInvoker(delegate { catListView.Items.Add(lIt); }));
                    }
                    catch { }
                    // add channels
                    foreach (Match m2 in Regex.Matches(m.Value, "<a href=\"(.*?)</a>", RegexOptions.Singleline))
                    {
                        string chanHashtag = Regex.Match(m2.Value, "\">(.*?)</a>", RegexOptions.IgnoreCase | RegexOptions.Singleline).Groups[1].Value;
                        chanHashtag = Regex.Replace(chanHashtag, @"\s+", string.Empty); // clean channel name
                        if (!chanHashtag.Contains("#"))
                            continue;
                        if (chanHashtag == "#top")
                            continue;
                        tmpChanList.Add(chanHashtag);
                    }
                    // add category name with channel list to associate with channels dictionary
                    categories.TryAdd(catTitle, tmpChanList);
                }
            }
        }
        #endregion

        #region winform_functions
        public chat_list()
        {
            InitializeComponent();
        }

        private void chanListView_DoubleClick(object sender, EventArgs e)
        {
            if (!chat.irc.IsClientRunning())
            {
                MessageBox.Show("ERROR: IRC client not running.");
                return;
            }

            chatroom cr = new chatroom(chanListView.SelectedItems[0].Text.ToLower());
            cr.Owner = this;
            cr.MdiParent = MdiParent;
            cr.Show();
        }

        private void chat_list_Shown(object sender, EventArgs e)
        {
            location.PositionWindow(this, 0, 50);
        }

        private void catListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catListView.SelectedItems.Count > 0)
                roomsIn.Text = "'" + catListView.SelectedItems[0].Text + "'";
        }

        private void mainTitle_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void catListView_MouseClick(object sender, MouseEventArgs e)
        {
            chanListView.Items.Clear();
            string key = catListView.SelectedItems[0].Text;
            foreach (string chan in categories[key])
            {
                ListViewItem lIt2 = new ListViewItem();
                lIt2.Tag = chan;
                lIt2.Text = chan.Replace("#", "");
                chanListView.Items.Add(lIt2);
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }

        private void chat_list_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(getChannels));
            thread.Start();
        }
        #endregion

        private void goChatBtn_Click(object sender, EventArgs e)
        {
            if (chanListView.SelectedItems.Count <= 0)
                return;
            chatroom cr = new chatroom(chanListView.SelectedItems[0].Text.ToLower());
            cr.Owner = this;
            cr.MdiParent = MdiParent;
            cr.Show();
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
