namespace Installer;
public partial class InstallForm : Form
{
    string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    public InstallForm()
    {
        InitializeComponent();

        installPath.Text = Path.Combine($"{appData}\\AOL 4.0 Emu");
    }

    private void installBtn_Click(object sender, EventArgs e)
    {
        InstallHelper.StartInstallation(installPath.Text);

        InstallHelper.CreateShortcut(installPath.Text);

        installBtn.Enabled = false;
        MessageBox.Show("AOL 4.0 Emu has been installed.", "Installation Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void browseBtn_Click(object sender, EventArgs e)
    {
        using (var dialog = new FolderBrowserDialog())
        {
            dialog.Description = "Select installation folder";
            dialog.ShowNewFolderButton = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = dialog.SelectedPath;
                installPath.Text = $"{selectedPath}\\AOL 4.0 Emu";
            }
        }
    }

    private void githubLink_Click(object sender, EventArgs e)
    {
        var psi = new System.Diagnostics.ProcessStartInfo
        {
            FileName = "https://github.com/erfg12/AOL_4.0_Emu",
            UseShellExecute = true
        };
        System.Diagnostics.Process.Start(psi);
    }
}
