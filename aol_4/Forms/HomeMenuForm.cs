using Microsoft.Extensions.DependencyInjection;

namespace aol.Forms;
public partial class HomeMenuForm : _Win95Theme
{
    private readonly AccountService account;
    public IServiceProvider ServiceProvider { get; }

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
        TitleLabel.Text = $"Welcome, {account.tmpUsername}";
        this.Text = TitleLabel.Text;
        temperatureLabel.Text = LocationService.GetCurrentWeather();
    }

    public HomeMenuForm(AccountService acc, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        account = acc;

        TitleBar.MouseMove += MoveWindow;
        TitleLabel.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
        ServiceProvider = serviceProvider;
    }

    private void MailCenterBtn_Click(object sender, EventArgs e)
    {
        var mailboxForm = this.ServiceProvider.GetRequiredService<MailboxForm>();
        MDIHelper.OpenForm(mailboxForm, MdiParent);
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
        var chatroomListForm = this.ServiceProvider.GetRequiredService<ChatroomListForm>();
        MDIHelper.OpenForm(chatroomListForm, MdiParent);
    }
}
