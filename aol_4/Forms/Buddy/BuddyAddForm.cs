using aol.Services;
using System;
using System.Windows.Forms;

namespace aol.Forms;
public partial class BuddyAddForm : Win95Theme
{
    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void MainTitle_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void add_buddy_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
    }

    public BuddyAddForm()
    {
        InitializeComponent();
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private async void sendBtn_Click(object sender, EventArgs e)
    {
        if (await RestAPIService.addBuddy(nameTextBox.Text))
            MessageBox.Show("Buddy Added!");
        else
            MessageBox.Show("Error: Buddy not added.");
        Close();
    }
}
