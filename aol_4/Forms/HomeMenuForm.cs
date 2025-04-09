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

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void miniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void home_menu_ShownAsync(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);

        todayLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        TitleBar_TitleLabel.Text = $"Welcome, {Account.tmpUsername}";
        temperatureLabel.Text = LocationService.getCurrentWeather();
    }

    public HomeMenuForm()
    {
        InitializeComponent();
    }

    private void mailCenterBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<MailboxForm>(MdiParent);
    }

    private void YouveGotPicturesBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<PicturesForm>(MdiParent);
    }

    private void aolChannelsBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<ChannelsListForm>(MdiParent);
    }

    private void chatBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<ChatroomListForm>(MdiParent);
    }

    private void HomeMenuForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
