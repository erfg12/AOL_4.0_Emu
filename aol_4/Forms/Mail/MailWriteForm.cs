using aol.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace aol.Forms;
public partial class MailWriteForm : Win95Theme
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
        maxiMini(maxBtn);
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }

    private void sendButton_Click(object sender, EventArgs e)
    {
        // parse <name> "address"; format
        foreach (KeyValuePair<string, string> entry in parseSendTo(sendToBox.Text))
        {
            MailService.sendEmail(entry.Key, entry.Value, subjectBox.Text, messageBox.Text);
        }
        MessageBox.Show("Your email has been sent!");
        Close();
    }

    private void panel1_DoubleClick(object sender, EventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void write_mail_Load(object sender, EventArgs e)
    {

    }

    private void write_mail_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 0, 55);
    }
}
