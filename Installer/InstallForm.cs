using Microsoft.Win32;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using System.Reflection;
using System.Security.Policy;

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
        //var names = Assembly.GetExecutingAssembly().GetManifestResourceNames();
        //foreach (var n in names) richTextBox1.AppendText(n + Environment.NewLine);

        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream("Setup.assets.pak");

        Directory.CreateDirectory(installPath.Text);

        using var archive = ZipArchive.Open(stream);
        foreach (var entry in archive.Entries.Where(e => !e.IsDirectory))
        {
            entry.WriteToDirectory(installPath.Text, new ExtractionOptions()
            {
                ExtractFullPath = true,   // preserves folder structure
                Overwrite = true           // overwrite existing files
            });
        }

        // Key path for your app
        string uninstallKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Uninstall\aol_4";

        // Open or create the key under CurrentUser
        using (RegistryKey key = Registry.CurrentUser.CreateSubKey(uninstallKeyPath))
        {
            key.SetValue("DisplayName", "AOL 4.0 Emu");
            key.SetValue("InstallPath", installPath.Text);
            key.SetValue("Version", "1.0.0");
            key.SetValue("Publisher", "Jacob Fliss");
            key.SetValue("LastInstalled", DateTime.Now.ToString());
            key.SetValue("UninstallString", Path.Combine(installPath.Text, "Uninstall.exe"));
            key.SetValue("DisplayIcon", Path.Combine(installPath.Text, "aol_icon.ico"));
        }

        CreateShortcut();

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

    private void CreateShortcut()
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string shortcut = Path.Combine(desktop, "AOL 4.0.url");

        File.WriteAllText(shortcut,
$@"[InternetShortcut]
URL=file:///{Path.Combine(installPath.Text, "aol.exe")}
IconIndex=0
IconFile={Path.Combine(installPath.Text, "aol.exe")}");
    }
}
