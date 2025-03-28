using aol.Classes;
using ServiceStack;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace aol.Forms;
public partial class ChannelsListForm : Win95Theme
{
    public void goToChannel (string channel, int width = 1105, int height = 650)
    {
        string title = $"{channel.ToTitleCase()} Channel";
        string path = Directory.GetCurrentDirectory() + @"\Channels\" + channel + ".htm";
        Debug.WriteLine(path);
        Form BrowseWnd = new ChannelViewForm(path, title);
        BrowseWnd.Owner = this;
        BrowseWnd.MdiParent = MdiParent;
        BrowseWnd.Width = width + 6;
        BrowseWnd.Height = height + 26;
        BrowseWnd.Show();
    }
    private void titleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }

    private void channels_Shown(object sender, EventArgs e)
    {
        LocationClass.PositionWindow(this);
    }

    private void KidsOnlyBtn_Click(object sender, EventArgs e)
    {
        goToChannel("kids");
    }

    private void channels_Load(object sender, EventArgs e)
    {
        
    }

    public ChannelsListForm()
    {
        InitializeComponent();
    }

    private void miniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void maxBtn_Click(object sender, EventArgs e)
    {

    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }
}
