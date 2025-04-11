namespace aol.Forms;
public partial class HomeMenuForm : _Win95Theme
{
    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void TitleBar_TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void HomeMenu_ShownAsync(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);

        todayLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        TitleBar_TitleLabel.Text = $"Welcome, {Account.tmpUsername}";
        temperatureLabel.Text = LocationService.GetCurrentWeather();
    }

    public HomeMenuForm()
    {
        InitializeComponent();
    }

    private void MailCenterBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<MailboxForm>(MdiParent);
    }

    private void YouveGotPicturesBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<PicturesForm>(MdiParent);
    }

    private void AolChannelsBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<ChannelsListForm>(MdiParent);
    }

    private void ChatBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<ChatroomListForm>(MdiParent);
    }

    private void HomeMenuForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
