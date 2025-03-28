namespace aol.Classes;

/// <summary>
/// This is a static class, and these variables can be shared around the program.
/// </summary>
class AccountClass
{
    public static string tmpLocation { get; set; }
    public static string tmpPassword { get; set; }
    public static string tmpUsername { get; set; }
    public static userAPI accountInfo { get; set; }
}
