namespace aol.Forms;
public partial class HomeMenuForm : _Win95Theme
{
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
        TitleLabel.Text = $"Welcome, {Account.Info.username}";
        this.Text = TitleLabel.Text;
        temperatureLabel.Text = LocationService.GetCurrentWeather();
    }

    public HomeMenuForm()
    {
        InitializeComponent();

        TitleBar.MouseMove += MoveWindow;
        TitleLabel.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
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
}
