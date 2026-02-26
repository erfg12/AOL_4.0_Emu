using Microsoft.Win32;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using System.Diagnostics;
using System.Reflection;

namespace Installer;
public class InstallHelper
{
    public static void CreateShortcut(string installPath)
    {
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string shortcut = Path.Combine(desktop, "AOL 4.0.url");

        File.WriteAllText(shortcut,
            $@"[InternetShortcut]
            URL=file:///{Path.Combine(installPath, "aol.exe")}
            IconIndex=0
            IconFile={Path.Combine(installPath, "aol.exe")}");
    }

    public static bool StartInstallation(string installPath)
    {
        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream("Setup.assets.pak");

        Directory.CreateDirectory(installPath);

        var exePath = Process.GetCurrentProcess().MainModule!.FileName!;
        var info = FileVersionInfo.GetVersionInfo(exePath);

        using var archive = ZipArchive.Open(stream);
        foreach (var entry in archive.Entries.Where(e => !e.IsDirectory))
        {
            entry.WriteToDirectory(installPath, new ExtractionOptions()
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
            key.SetValue("InstallPath", installPath);
            key.SetValue("DisplayVersion", info.FileVersion ?? "1.0.999.0");
            key.SetValue("Publisher", "Jacob Fliss");
            key.SetValue("LastInstalled", DateTime.Now.ToString());
            key.SetValue("UninstallString", Path.Combine(installPath, "Uninstall.exe"));
            key.SetValue("DisplayIcon", Path.Combine(installPath, "aol_icon.ico"));
        }

        return true;
    }
}
