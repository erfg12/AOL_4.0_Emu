namespace aol.Forms;
public partial class MailboxForm : _Win95Theme
{
    public MailboxForm()
    {
        InitializeComponent();
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.ResizeRedraw, true);
        this.Dock = DockStyle.Fill;

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        mainTitle.MouseMove += MoveWindow;
        mainTitle.DoubleClick += TitleBar_DoubleClick;
        TitleBar.DoubleClick += TitleBar_DoubleClick;
        maxBtn.Click += MaxRestoreButton_Click;
    }

    private void GetEmail()
    {
        MailService.GetEmail();
        foreach (KeyValuePair<string, string> entry in MailService.emailsNew)
        {
            ListViewItem lIt = new ListViewItem();
            lIt.Tag = entry.Key;
            lIt.Text = entry.Value;
            //Debug.WriteLine("[MAIL] Adding NEW Key(tag):" + entry.Key + " Value(text):" + entry.Value);
            try
            {
                newListView.Invoke(new MethodInvoker(delegate { newListView.Items.Add(lIt); }));
            }
            catch
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
            }
            catch
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
            }
            catch { }
        }
    }

    void MoveToOld()
    {
        if (newListView.SelectedItems.Count <= 0)
            return;

        MailService.MarkAsSeen(newListView.SelectedItems[0].Tag.ToString());
        ListViewItem lIt = new ListViewItem();
        lIt.Tag = newListView.SelectedItems[0].Tag.ToString();
        lIt.Text = newListView.SelectedItems[0].Text;
        oldListView.Items.Add(lIt);
        newListView.Items.RemoveAt(newListView.SelectedItems[0].Index);
        if (newListView.Items.Count == 0)
            MailService.youGotMail = false;
    }

    private void OpenReadEmail(string subject, string emailID)
    {
        MDIHelper.OpenForm(() => new MailReadForm(subject, emailID), MdiParent);
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        if (newListView.Visible)
        {
            if (newListView.SelectedItems.Count <= 0)
            {
                OpenMsgBox("ERROR", "Select an email first.");
                return;
            }

            MailService.DeleteEmail(newListView.SelectedItems[0].Tag.ToString());
            newListView.Items.RemoveAt(newListView.SelectedItems[0].Index);
            Debug.WriteLine("[MAIL] new mail count: " + newListView.Items.Count + " YGM flag: " + MailService.youGotMail);
            if (newListView.Items.Count == 0)
                MailService.youGotMail = false;
        }
        else if (oldListView.Visible)
        {
            if (oldListView.SelectedItems.Count <= 0)
            {
                OpenMsgBox("ERROR", "Select an email first.");
                return;
            }

            MailService.DeleteEmail(oldListView.SelectedItems[0].Tag.ToString());
            oldListView.Items.RemoveAt(oldListView.SelectedItems[0].Index);
        }
        else if (sentListView.Visible)
        {
            if (sentListView.SelectedItems.Count <= 0)
            {
                OpenMsgBox("ERROR", "Select an email first.");
                return;
            }

            MailService.DeleteEmail(sentListView.SelectedItems[0].Tag.ToString());
            sentListView.Items.RemoveAt(sentListView.SelectedItems[0].Index);
        }
        MessageBox.Show("Email has been deleted.");
    }

    private void KeepBtn_Click(object sender, EventArgs e)
    {
        if (oldListView.SelectedItems.Count <= 0)
        {
            OpenMsgBox("ERROR", "Select an email first.");
            return;
        }

        if (oldListView.Visible) // only works on old emails
        {
            MailService.MarkAsUnseen(oldListView.SelectedItems[0].Tag.ToString());
            ListViewItem lIt = new ListViewItem();
            lIt.Tag = oldListView.SelectedItems[0].Tag.ToString();
            lIt.Text = oldListView.SelectedItems[0].Text;
            newListView.Items.Add(lIt);
            oldListView.Items.RemoveAt(oldListView.SelectedItems[0].Index);
        }
    }

    private void ReadBtn_Click(object sender, EventArgs e)
    {
        if (newListView.Visible && newListView.SelectedItems.Count > 0)
        {
            OpenReadEmail(newListView.SelectedItems[0].Text, newListView.SelectedItems[0].Tag.ToString());
            MoveToOld();
        }
        else if (newListView.Visible && newListView.SelectedItems.Count <= 0)
        {
            OpenMsgBox("ERROR", "Select an email first.");
            return;
        }

        if (oldListView.Visible && oldListView.SelectedItems.Count > 0)
            OpenReadEmail(oldListView.SelectedItems[0].Text, oldListView.SelectedItems[0].Tag.ToString());
        else if (oldListView.Visible && oldListView.SelectedItems.Count <= 0)
        {
            OpenMsgBox("ERROR", "Select an email first.");
            return;
        }

        if (sentListView.Visible && sentListView.SelectedItems.Count > 0)
            OpenReadEmail(sentListView.SelectedItems[0].Text, sentListView.SelectedItems[0].Tag.ToString());
        else if (sentListView.Visible && sentListView.SelectedItems.Count <= 0)
        {
            OpenMsgBox("ERROR", "Select an email first.");
            return;
        }
    }

    private void Mailbox_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 0, 55);
        Thread thread = new Thread(new ThreadStart(GetEmail));
        thread.Start();
        Text = $"{Account.tmpUsername}'s Online Mailbox";
        mainTitle.Text = $"{Account.tmpUsername}'s Online Mailbox";
    }

    private void NewListview_DoubleClick(object sender, EventArgs e)
    {
        if (newListView.SelectedItems.Count <= 0)
        {
            OpenMsgBox("ERROR", "Select an email first.");
            return;
        }

        OpenReadEmail(newListView.SelectedItems[0].Text, newListView.SelectedItems[0].Tag.ToString());
        MoveToOld();
    }

    private void OldListView_DoubleClick(object sender, EventArgs e)
    {
        if (oldListView.SelectedItems.Count <= 0)
        {
            OpenMsgBox("ERROR", "Select an email first.");
            return;
        }

        OpenReadEmail(oldListView.SelectedItems[0].Text, oldListView.SelectedItems[0].Tag.ToString());
    }

    private void SentListView_DoubleClick(object sender, EventArgs e)
    {
        if (sentListView.SelectedItems.Count <= 0)
        {
            OpenMsgBox("ERROR", "Select an email first.");
            return;
        }

        OpenReadEmail(sentListView.SelectedItems[0].Text, sentListView.SelectedItems[0].Tag.ToString());
    }
}
