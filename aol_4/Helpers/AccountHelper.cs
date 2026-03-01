
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

    /// <summary>
    /// create md5 encrypted string
    /// </summary>
    /// <param name="input">plain string to encrypt</param>
    /// <returns>md5 string</returns>
    public static string CreateMD5(string input)
    {
        // Use input string to calculate MD5 hash
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
