namespace aol.Forms;
public partial class DialUpForm : _Win95Theme
{
    string verbage = "TCP/IP";
    int dialUpStep = 0;

    public DialUpForm()
    {
        InitializeComponent();
        TopLevel = true;
        Focus();
        if (Account.tmpLocation == "Dial-Up")
            verbage = "Dial-Up";
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
                if (Account.tmpLocation == "Dial-Up")
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

        HomeMenuForm hm = new HomeMenuForm()
        {
            Owner = mainForm,
            MdiParent = mainForm
        };
        hm.Show();

        if (Account.Info.password != "Guest")
        {
            mainForm.checkMail.Enabled = true;
            mainForm.checkMail.Start();

            BuddyListForm bo = new BuddyListForm()
            {
                Owner = mainForm,
                MdiParent = mainForm
            };
            bo.Show();

            mainForm.ReloadAddressBarHistory();
        }

        mainForm.ReloadAddressBarHistory();

        mainForm.signOffBtn.Text = "Sign Off";

        mainForm.StartProgram();
    }
}
