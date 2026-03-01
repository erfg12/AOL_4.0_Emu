namespace aol.Forms;
public partial class BuddyAddForm : _Win95Theme
{
    private readonly RestAPIService restApi;
    public BuddyAddForm(RestAPIService ras)
    {
        InitializeComponent();
        restApi = ras;
    }

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
        nameTextBox.Focus();
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
        var addBuddy = await restApi.AddBuddy(nameTextBox.Text);

        if (addBuddy.Item1)
        {
            OpenMsgBox("INFO", "Buddy Added!");
            BuddyListForm buddyListForm = (BuddyListForm)Application.OpenForms["BuddyListForm"];
            buddyListForm?.UpdateBuddyStatus();
        }
        else
            OpenMsgBox("ERROR", addBuddy.Item2);
        Close();
    }
}
