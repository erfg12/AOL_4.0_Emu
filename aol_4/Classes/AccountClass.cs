public class Models
{
    public class Account
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
    }

    public class Email
    {
        public int id { get; set; }
        public string address { get; set; }
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int imapPort { get; set; }
        public int smtpPort { get; set; }
        public int useSSL { get; set; }
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
        public string buddy_name { get; set; }
        /// <summary>
        /// The user who has the buddy in their list
        /// </summary>
        public int userid { get; set; }
    }

}