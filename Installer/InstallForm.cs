using System.IO;

namespace Installer;
public partial class InstallForm : Form
{
    string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    public InstallForm()
    {
        InitializeComponent();

        installPath.Text = Path.Combine($"{appData}\\AOL 4.0 Emu");
    }

    private async void installBtn_Click(object sender, EventArgs e)
    {
        progressBar1.Minimum = 0;
        progressBar1.Maximum = 100;

        var progress = new Progress<int>(v => progressBar1.Value = v);
        var log = new Progress<string>(path =>
        {
            outputBox.AppendText(path + Environment.NewLine);
            outputBox.ScrollToCaret();
        });

        await InstallHelper.StartInstallationAsync(installPath.Text, progress, log);

        InstallHelper.CreateShortcut(installPath.Text);

        installBtn.Enabled = false;
        browseBtn.Enabled = false;
        installPath.Enabled = false;

        outputBox.SelectionStart = outputBox.TextLength;
        outputBox.SelectionLength = 0;
        outputBox.SelectionColor = Color.Green;
        outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Bold);

        outputBox.AppendText("Installation finished! Check your desktop for the app shortcut." + Environment.NewLine);
        MessageBox.Show("AOL 4.0 Emu has been installed." + Environment.NewLine + "Check your desktop for the app shortcut.", "Installation Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
