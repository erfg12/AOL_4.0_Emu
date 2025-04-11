public class UserAPI
{
    public Account? account { get; set; }
    public List<Buddies>? buddies { get; set; }
    public string? message { get; set; }

    public class Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string ipaddress { get; set; }
    }

    public class Buddies
    {
        /// <summary>
        /// autoincremented id for the buddy, used for deleting
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// The username of the buddy
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// The user who has the buddy in their list
        /// </summary>
        public int userid { get; set; }
    }
}
