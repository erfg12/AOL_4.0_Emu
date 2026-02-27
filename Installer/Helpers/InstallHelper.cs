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

    public static async Task<bool> StartInstallationAsync(
    string installPath,
    IProgress<int>? progress = null,
    IProgress<string>? log = null)
    {
        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream("Setup.assets.pak")
            ?? throw new InvalidOperationException("assets.pak not found");

        Directory.CreateDirectory(installPath);

        var exePath = Process.GetCurrentProcess().MainModule!.FileName!;
        var info = FileVersionInfo.GetVersionInfo(exePath);

        using var archive = ZipArchive.Open(stream);
        var entries = archive.Entries.Where(e => !e.IsDirectory).ToList();

        long totalBytes = entries.Sum(e => e.Size);
        long extractedBytes = 0;

        await Task.Run(() =>
        {
            foreach (var entry in entries)
            {
                entry.WriteToDirectory(installPath, new ExtractionOptions
                {
                    ExtractFullPath = true,
                    Overwrite = true
                });

                var fullPath = Path.Combine(installPath, entry.Key);
                log?.Report(fullPath);

                extractedBytes += entry.Size;
                progress?.Report((int)(extractedBytes * 100 / totalBytes));
            }
        });

        using var key = Registry.CurrentUser.CreateSubKey(
            @"Software\Microsoft\Windows\CurrentVersion\Uninstall\aol_4");

        key!.SetValue("DisplayName", "AOL 4.0 Emu");
        key.SetValue("InstallPath", installPath);
        key.SetValue("DisplayVersion", info.FileVersion ?? "1.0.999.0");
        key.SetValue("Publisher", "Jacob Fliss");
        key.SetValue("LastInstalled", DateTime.Now.ToString());
        key.SetValue("UninstallString", Path.Combine(installPath, "Uninstall.exe"));
        key.SetValue("DisplayIcon", Path.Combine(installPath, "aol_icon.ico"));

        progress?.Report(100);
        return true;
    }
}
