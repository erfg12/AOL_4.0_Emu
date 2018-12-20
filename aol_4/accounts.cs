using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace aol
{
    class accounts
    {
        private SQLiteConnection openDB()
        {
            var pathDB = System.IO.Path.Combine(Environment.CurrentDirectory, "accounts.db");
            if (!System.IO.File.Exists(pathDB)) throw new Exception();
            return new SQLiteConnection("Data Source=" + openDB() + ";Version=3;");
        }

        /// <summary>
        /// Returns 0 on success, otherwise an error number will be given.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass">encrypted</param>
        /// <returns></returns>
        public int createAcc(string user, string pass)
        {
            int code = 0;

            SQLiteConnection m_dbConnection = openDB();

            m_dbConnection.Open();

            string sql = "INSERT INTO accounts (username, password) VALUES ('" + user + "', '" + pass + "')";

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                code = ex.ErrorCode;
            }

            m_dbConnection.Close();

            return code;
        }

        /// <summary>
        /// Returns the users account ID. If 0, we failed to get the account.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass">encrypted</param>
        /// <returns></returns>
        public int loginAcc(string user, string pass)
        {
            int foundAcc = 0;

            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            string sql = "SELECT userid FROM accounts WHERE username = " + user + " AND password = " + pass;
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) > 0)
                    foundAcc = reader.GetInt32(0);
            }

            m_dbConnection.Close();

            return foundAcc;
        }
    }
}
