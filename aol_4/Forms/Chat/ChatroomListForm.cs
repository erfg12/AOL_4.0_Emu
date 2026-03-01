namespace aol.Forms;
public partial class ChatroomListForm : _Win95Theme
{
    AccountService account;
    ChatService chat;

    private ConcurrentDictionary<string, List<string>> categories = new();

    public static string StripHTML(string input)
    {
        return Regex.Replace(input, "<.*?>", String.Empty);
    }

    private void getChannels()
    {
        using WebClient client = new();

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

    public ChatroomListForm(AccountService acc, ChatService cs)
    {
        InitializeComponent();

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        mainTitle.MouseMove += MoveWindow;
        account = acc;
        chat = cs;
    }

    private void chanListView_DoubleClick(object sender, EventArgs e)
    {
        if (!chat.irc.IsClientRunning())
        {
            OpenMsgBox("ERROR", "IRC client not running.");
            return;
        }

        ChatroomForm cr = new ChatroomForm(chat, account, chanListView.SelectedItems[0].Text.ToLower());
        cr.Owner = this;
        cr.MdiParent = MdiParent;
        cr.Show();
    }

    private void chat_list_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 0, 50);
    }

    private void catListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (catListView.SelectedItems.Count > 0)
            roomsIn.Text = "'" + catListView.SelectedItems[0].Text + "'";
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

    private void miniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void chat_list_Load(object sender, EventArgs e)
    {
        Thread thread = new Thread(new ThreadStart(getChannels));
        thread.Start();
    }

    private void goChatBtn_Click(object sender, EventArgs e)
    {
        if (chanListView.SelectedItems.Count <= 0)
            return;
        ChatroomForm cr = new ChatroomForm(chat, account, chanListView.SelectedItems[0].Text.ToLower());
        cr.Owner = this;
        cr.MdiParent = MdiParent;
        cr.Show();
    }

    private void searchBtn_Click(object sender, EventArgs e)
    {

    }
}
