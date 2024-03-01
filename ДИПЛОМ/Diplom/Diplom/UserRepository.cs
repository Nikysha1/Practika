using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Data.SqlClient;

namespace Diplom
{
    class UserRepository
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;";

        public static User GetUser(string username, string password)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                return dbConnection.QueryFirstOrDefault<User>(query, new { Username = username, Password = password });
            }
        }

        public static void InsertUser(string username, string password)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                dbConnection.Execute(query, new { Username = username, Password = password });
            }
        }

        public static bool IsUsernameTaken(string username)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username";
                var user = dbConnection.QueryFirstOrDefault<User>(query, new { Username = username });

                return user != null;
            }
        }

    }
}
