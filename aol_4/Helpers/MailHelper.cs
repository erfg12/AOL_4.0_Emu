namespace aol.Helpers;

class MailHelper
{
    /// <summary>
    /// Parses a semicolon-separated list of email addresses and names.
    /// </summary>
    /// <param name="parse"></param>
    /// <returns></returns>
    public static ConcurrentDictionary<string, string> ParseEmails(string parse)
    {
        ConcurrentDictionary<string, string> list = new();
        string[] replaceThese = new string[] { "<", ">", "\"" };

        if (parse.Contains(";"))
        {
            string[] eachAddr = parse.Split(';');

            foreach (string addr in eachAddr)
            {
                if (addr == "")
                    continue;

                if (addr.Contains("<"))
                {
                    string[] info = addr.Split('<');
                    string cleanName = info[0];
                    string cleanAddr = info[1];

                    foreach (string r in replaceThese)
                    {
                        cleanName = cleanName.Replace(r, "").Trim();
                        cleanAddr = cleanAddr.Replace(r, "").Trim();
                        Debug.WriteLine("[MAIL] replacing " + r);
                    }
                    Debug.WriteLine("[MAIL] Adding 0:" + cleanName + " 1:" + cleanAddr);
                    if (!list.ContainsKey(cleanName))
                        list.TryAdd(cleanName, cleanAddr);
                }
                else
                {
                    list.TryAdd("", addr);
                }
            }
        }
        else
        {
            list.TryAdd("", parse);
        }

        return list;
    }
}
