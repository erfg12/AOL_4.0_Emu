namespace aol.Helpers;
class BrowserHelper
{
    public static string GenerateURLFromString(string urlArg)
    {
        string url = "https://www.google.com";
        if (!urlArg.Contains("."))
            url = searchProvider(urlArg);
        else
            url = urlArg.StartsWith("http") ? urlArg : urlArg = "https://" + urlArg;

        return url;
    }

    public static string searchProvider(string query)
    {
        switch (Properties.Settings.Default.searchProvider)
        {
            case "DuckDuckGo":
                return $"https://duckduckgo.com/?q={query}";
            case "Bing":
                return $"https://www.bing.com/search?q={query}";
            case "Google":
                return $"https://www.google.com/search?q={query}";
            case "Yahoo":
                return $"https://search.yahoo.com/search?p={query}";
            default:
                return "";
        }
    }
}
