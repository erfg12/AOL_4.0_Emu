namespace aol.Services;

/// <summary>
/// This is a static class, and these variables can be shared around the program.
/// </summary>
class Account
{
    public static string tmpLocation { get; set; }
    public static Models.Account Info { get; set; }
    public static Models.Email Email { get; set; }
    public static List<Models.Buddies> Buddies { get; set; }

    public static string homePageUrl = "https://www.aol.com";

    public static bool SignedIn()
    {
        if (Info.username.IsNullOrEmpty() || Info.username == "Guest")
            return false;

        return Info != null;
    }
}
