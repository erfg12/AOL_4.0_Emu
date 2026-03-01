using Microsoft.Extensions.DependencyInjection;
using static UserAPI;

namespace aol.Forms;
public partial class DialUpForm : _Win95Theme
{
    string verbage = "TCP/IP";
    int dialUpStep = 0;
    public IServiceProvider serviceProvider { get; }
    private readonly ChatService chat;
    private readonly AccountService account;

    public DialUpForm(IServiceProvider sp, ChatService cs, AccountService acc)
    {
        InitializeComponent();

        serviceProvider = sp;
        account = acc;
        chat = cs;
        if (account.tmpLocation == "Dial-Up")
            verbage = "Dial-Up";

        TopLevel = true;
        Focus();
    }

    async Task DialUp()
    {
        timer1.Stop();
        verbage = "Dial-Up";
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.dial_up_modem;
            player.Play();
        }
        await Task.Delay(25000);
        timer1.Start();
    }

    private async void Timer1_Tick(object sender, EventArgs e)
    {
        switch (dialUpStep)
        {
            case 0: // pretend to initialize the modem
                statusLabel.Text = "Step 1: Looking for AOL via " + verbage + "...";
                break;
            case 1: // pretend to connect to server
                pictureBox1.Visible = Visible;
                statusLabel.Text = "Step 2: Connecting using " + verbage + " ...";
                if (account.tmpLocation == "Dial-Up")
                    await DialUp();
                break;
            case 2: // pretend to check password
                pictureBox2.Visible = Visible;
                statusLabel.Text = "Step 3: Checking password ...";
                break;
            case 3: // show final running man
                pictureBox3.Visible = Visible;
                break;
            case 4: // play welcome audio msg and close form
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) break;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Welcome;
                player.Play();
                Close();
                break;
            default:
                break;
        }
        dialUpStep++;
    }

    private void DialUpForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        var mainForm = (MainForm)this.MdiParent;

        HomeMenuForm hm = new HomeMenuForm(account, serviceProvider)
        {
            Owner = mainForm,
            MdiParent = mainForm
        };
        hm.Show();

        if (account.tmpUsername != "Guest")
        {
            mainForm.checkMail.Enabled = true;
            mainForm.checkMail.Start();

            var buddyListForm = this.serviceProvider.GetRequiredService<BuddyListForm>();
            MDIHelper.OpenForm(buddyListForm, mainForm);

            mainForm.ReloadAddressBarHistory();
        }

        mainForm.ReloadAddressBarHistory();

        mainForm.signOffBtn.Text = "Sign Off";

        mainForm.StartProgram();
    }
}
