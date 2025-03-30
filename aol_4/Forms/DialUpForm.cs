using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using aol.Services;

namespace aol.Forms;
public partial class DialUpForm : Form
{
    #region win95_theme
    int _ = 2;

    new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
    new Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
    new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
    new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

    protected override void OnPaint(PaintEventArgs e)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
        e.Graphics.FillRectangle(Brushes.Gray, Top);
        e.Graphics.FillRectangle(Brushes.Gray, Left);
        e.Graphics.FillRectangle(Brushes.Gray, Right);
        e.Graphics.FillRectangle(Brushes.Gray, Bottom);
    }
    #endregion

    public DialUpForm()
    {
        InitializeComponent();
        TopLevel = true;
        Focus();
        if (Account.tmpLocation == "Dial-Up")
            verbage = "Dial-Up";
    }

    string verbage = "TCP/IP";
    int i = 0;

    async Task dialUp()
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

    private async void timer1_Tick(object sender, EventArgs e)
    {
        switch (i)
        {
            case 0: // pretend to initialize the modem
                statusLabel.Text = "Step 1: Looking for AOL via " + verbage + "...";
                break;
            case 1: // pretend to connect to server
                pictureBox1.Visible = Visible;
                statusLabel.Text = "Step 2: Connecting using " + verbage + " ...";
                if (Account.tmpLocation == "Dial-Up")
                    await dialUp();
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
        i++;
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

        if (Account.tmpUsername != "Guest")
        {
            mainForm.checkMail.Enabled = true;
            mainForm.checkMail.Start();

            BuddyListForm bo = new BuddyListForm()
            {
                Owner = mainForm,
                MdiParent = mainForm
            };
            bo.Show();

            mainForm.reloadAddressBarHistory();
        }

        mainForm.reloadAddressBarHistory();

        mainForm.signOffBtn.Text = "Sign Off";

        mainForm.startProgram();
    }
}
