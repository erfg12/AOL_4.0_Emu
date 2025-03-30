namespace aol.Services;

/// <summary>
/// This is a static class, and these variables can be shared around the program.
/// </summary>
class Account
{
    public static string tmpLocation { get; set; }
    public static string tmpPassword { get; set; }
    public static string tmpUsername { get; set; }
    public static userAPI accountInfo { get; set; }

    public static bool SignedIn()
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return false;

        return accountInfo?.account != null;
    }
}
