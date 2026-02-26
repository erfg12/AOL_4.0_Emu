using System.Text.Json;

namespace aol.Helpers;

public class VersionHelper
{
    public static string GetCurrentVersion()
    {
        var exePath = Process.GetCurrentProcess().MainModule!.FileName!;
        var info = FileVersionInfo.GetVersionInfo(exePath);

        return info.FileVersion ?? "1.0.999.0";
    }

    public static string GetLatestVersion()
    {
        try
        {
            using var client = new HttpClient();
            var response = client.GetStringAsync("https://api.github.com/repos/erfg12/AOL_4.0_Emu/releases/latest").Result;
            return JsonDocument.Parse(response).RootElement.GetProperty("tag_name").GetString() ?? "1.0.999.0";
        }
        catch
        {
            return "1.0.999.0";
        }
    }

    public static bool CheckForUpdates()
    {
        var currentVersion = new Version(GetCurrentVersion());
        var latestVersion = new Version(GetLatestVersion());
        return latestVersion > currentVersion;
    }
}
