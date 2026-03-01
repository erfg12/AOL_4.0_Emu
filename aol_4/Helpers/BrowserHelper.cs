namespace aol.Helpers;
class BrowserHelper
{
    public static string GenerateURLFromString(string urlArg, string homepage)
    {
        string url = homepage;
        if (!urlArg.Contains("."))
            url = SearchProvider(urlArg);
        else
            url = urlArg.StartsWith("http") ? urlArg : urlArg = "https://" + urlArg;

        return url;
    }

    public static string SearchProvider(string query)
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
            case "Dogpile":
                return $"https://www.dogpile.com/serp?q={query}";
            case "AOL":
                return $"https://search.aol.com/aol/search?q={query}";
            default:
                return "";
        }
    }
}
