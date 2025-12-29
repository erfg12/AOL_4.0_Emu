using Sentry.Protocol;
using System.Security.Cryptography;

namespace aol.Helpers;

public static class ChatHelper
{
    private static byte[] salt { get => Encoding.UTF8.GetBytes("AOL4.0Emu"); }

    /// <summary>
    /// Generates path with file extension. Creates if doesn't exist. Should be DRIVE:/user/PC_USERNAME/AppData/local/AOL_4_Emu/chatlogs/MY_USERNAME/(CHATROOM NAME|PM USERNAME).chat
    /// </summary>
    /// <returns>path to chat log</returns>
    public static string GetChatPath(string username, string filename)
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), $"AOL_4_Emu\\chatlogs\\{username}");
        var fileWithPath = Path.Combine(path, $"{filename}.chat");

        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        if (!File.Exists(fileWithPath))
            File.Create(fileWithPath).Dispose();

        return fileWithPath;
    }

    // these encrypt/decrypt methods can maybe move to their own files later.
    // atm they are only used for chat logs. not implemented yet.

    public static byte[] DecryptBytes(byte[] cipherBytes)
    {
        using var aes = Aes.Create();
        using var derive = new Rfc2898DeriveBytes(Account.Info.password, salt, 100_000, HashAlgorithmName.SHA256);

        aes.Key = derive.GetBytes(32);
        aes.IV = derive.GetBytes(16);

        using var ms = new MemoryStream();
        using var crypto = new CryptoStream(new MemoryStream(cipherBytes), aes.CreateDecryptor(), CryptoStreamMode.Read);
        crypto.CopyTo(ms);
        return ms.ToArray();
    }

    public static byte[] EncryptBytes(byte[] plainBytes)
    {
        using var aes = Aes.Create();
        using var derive = new Rfc2898DeriveBytes(Account.Info.password, salt, 100_000, HashAlgorithmName.SHA256);

        aes.Key = derive.GetBytes(32);
        aes.IV = derive.GetBytes(16);

        using var ms = new MemoryStream();
        using var crypto = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
        crypto.Write(plainBytes, 0, plainBytes.Length);
        crypto.FlushFinalBlock();
        return ms.ToArray();
    }


}
