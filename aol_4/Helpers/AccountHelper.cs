
namespace aol.Helpers;

public class AccountHelper
{
    public static List<string> notAllowedUsernames = new List<string>() {
            "guest",
            "admin",
            "administration",
            "administrator",
            "webadmin",
            "webmin"
        };
}
