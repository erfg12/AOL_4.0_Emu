namespace aol.Services;

/// <summary>
/// This is a static class, and these variables can be shared around the program.
/// </summary>
class Account
{
    public static Models.Account Info { get; set; } = new Models.Account();
    public static Models.Email Email { get; set; } = new Models.Email();
    public static List<Models.Buddies> Buddies { get; set; } = new List<Models.Buddies>();

    public static string homePageUrl = "https://www.aol.com";

    public static bool SignedIn()
    {
        if (Info.username.IsNullOrEmpty() || Info.username == "Guest")
            return false;

        return Info != null;
    }
}
