using Microsoft.Win32;

namespace Uninstall;
public partial class UninstallForm : Form
{
    string installPath = null;
    bool uninstall = false;

    public UninstallForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        
    }

    private void UninstallForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (uninstall)
        {
            string uninstallExe = Path.Combine(installPath, "Uninstall.exe");
            string cmd = $"/C ping 127.0.0.1 -n 2 > nul && del \"{uninstallExe}\" && rmdir /s /q \"{installPath}\"";

            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = cmd,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            System.Diagnostics.Process.Start(psi);
        }
    }

    private void uninstallBtn_Click(object sender, EventArgs e)
    {
        uninstallBtn.Enabled = false;
        using RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall\aol_4");

        if (key == null)
            return;

        installPath = key.GetValue("InstallPath") as string;

        UninstallProcess();

        uninstall = true;

        Registry.CurrentUser.DeleteSubKeyTree(@"Software\aol_4", false);

        // Remove uninstall entry so it disappears from Programs & Features
        Registry.CurrentUser.DeleteSubKeyTree(
            @"Software\Microsoft\Windows\CurrentVersion\Uninstall\aol_4", false
        );

        DeleteDesktopShortcut();

        MessageBox.Show("AOL 4.0 Emu has been uninstalled.", "Uninstallation Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

        Application.Exit();
    }

    bool UninstallProcess()
    {
        if (!string.IsNullOrEmpty(installPath) && Directory.Exists(installPath))
        {
            try
            {
                foreach (var file in Directory.GetFiles(installPath, "*", SearchOption.AllDirectories))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception ex)
                    {

                    }
                }

                foreach (var dir in Directory.GetDirectories(installPath, "*", SearchOption.AllDirectories).Reverse())
                {
                    try
                    {
                        Directory.Delete(dir);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        else
        {
            return false;
        }

        return true;
    }

    private void DeleteDesktopShortcut()
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string shortcut = Path.Combine(desktop, "AOL 4.0.lnk"); // or .url if you used that

        if (System.IO.File.Exists(shortcut))
        {
            System.IO.File.Delete(shortcut);
        }

    }
}
