namespace aol.Forms;
public partial class BuddyAddForm : _Win95Theme
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

    private void AddBuddy_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
    }

    public BuddyAddForm()
    {
        InitializeComponent();
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private async void SendBtn_Click(object sender, EventArgs e)
    {
        var addBuddy = SqliteAccountsService.AddBuddy(nameTextBox.Text);

        if (addBuddy)
            OpenMsgBox("INFO", "Buddy Added!");
        else
            OpenMsgBox("ERROR", "Error adding buddy");
        Close();
    }
}
