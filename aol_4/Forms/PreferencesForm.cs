namespace aol.Forms;
public partial class PreferencesForm : _Win95Theme
{
    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
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

    private void GeneralBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<SettingsForm>(MdiParent);
    }

    public PreferencesForm()
    {
        InitializeComponent();
    }

    private void PreferencesForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
