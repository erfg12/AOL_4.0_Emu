namespace aol.Forms;
public partial class MailWriteForm : _Win95Theme
{
    // key = name, value = address
    private ConcurrentDictionary<string, string> parseSendTo(string parse)
    {
        ConcurrentDictionary<string, string> list = new ConcurrentDictionary<string, string>();
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
                        list.TryAdd(cleanName, cleanAddr);
                }
                else
                {
                    list.TryAdd("", addr);
                }
            }
        }
        else
        {
            list.TryAdd("", parse);
        }

        return list;
    }

    public MailWriteForm(string sendTo = "", string subject = "")
    {
        InitializeComponent();
        FormBorderStyle = FormBorderStyle.None;
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
        Dock = DockStyle.Fill;

        sendToBox.Text = sendTo;
        subjectBox.Text = subject;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void MaxBtn_Click(object sender, EventArgs e)
    {
        MaxiMini(maxBtn);
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void SendButton_Click(object sender, EventArgs e)
    {
        // parse <name> "address"; format
        foreach (KeyValuePair<string, string> entry in parseSendTo(sendToBox.Text))
        {
            MailService.SendEmail(entry.Key, entry.Value, subjectBox.Text, messageBox.Text);
        }
        OpenMsgBox("INFO", "Your email has been sent!");
        Close();
    }

    private void TitleBar_DoubleClick(object sender, EventArgs e)
    {
        MaxiMini(maxBtn);
    }

    private void WriteMail_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 0, 55);
    }

    private void MailWriteForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
