namespace aol.Services;

/// <summary>
/// This is a static class, and these variables can be shared around the program.
/// </summary>
public class AccountService
{
    public string tmpLocation { get; set; }
    public string tmpPassword { get; set; }
    public string tmpUsername { get; set; }
    public UserAPI accountInfo { get; set; }

    public string homePageUrl = "https://www.aol.com";

    public bool SignedIn()
    {
        if (this.tmpUsername.IsNullOrEmpty() || this.tmpUsername.IsNullOrEmpty() || this.tmpUsername == "Guest")
            return false;

        return accountInfo?.account != null;
    }
}