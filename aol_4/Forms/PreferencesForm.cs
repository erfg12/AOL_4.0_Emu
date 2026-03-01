using Microsoft.Extensions.DependencyInjection;

namespace aol.Forms;
public partial class PreferencesForm : _Win95Theme
{
    public IServiceProvider serviceProvider { get; }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void GeneralBtn_Click(object sender, EventArgs e)
    {
        var settingsForm = serviceProvider.GetRequiredService<SettingsForm>();
        MDIHelper.OpenForm(settingsForm, MdiParent);
    }

    public PreferencesForm(IServiceProvider sp)
    {
        InitializeComponent();

        serviceProvider = sp;

        TitleBar.MouseMove += MoveWindow;
        titleLabel.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
    }
}
