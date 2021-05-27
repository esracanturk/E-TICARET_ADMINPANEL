using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace TicaretAPI.Models
{
    public class UsersRepository
    {
        private string connectionString;

        public UsersRepository()
        {
            connectionString = "Server=DESKTOP-REC6226;Database=TicaretDB;Integrated Security=true;Pooling=true;";
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public IEnumerable<Users> GetAllUser()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Users ";
                dbConnection.Open();
                return dbConnection.Query<Users>(sQuery);
            }
        }

        public Users GetById(int userid)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Users WHERE userid=@userid";
                dbConnection.Open();
                return dbConnection.Query<Users>(sQuery, new { userid = userid }).FirstOrDefault();
            }
        }

        public Users GetByUser(string username, string password)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Users WHERE username=@username and password=@password";
                dbConnection.Open();
                return dbConnection.Query<Users>(sQuery, new { username = username, password = password }).FirstOrDefault();
            }
        }

        public Users FindUser(string username, string password)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Users WHERE username=@username and password=@password";
                dbConnection.Open();
                return dbConnection.Query<Users>(sQuery, new { username = username, password = password }).FirstOrDefault();
            }
        }

        public Users FindEmail(string email)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Users WHERE email=@email";
                dbConnection.Open();
                return dbConnection.Query<Users>(sQuery, new { email = email }).FirstOrDefault();
            }
        }

        public void AddUser(Users user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Users (username,password,role,email,emailconfirm) VALUES(@username,@password,@role,@email,@emailconfirm)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, user);
            }
        }

        public void UpdateUser(Users user)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Users SET username=@username,password=@password,role=@role,email=@email,emailconfirm=@emailconfirm
                                WHERE userid=@userid";
                dbConnection.Open();
                dbConnection.Execute(sQuery, user);
            }
        }

        public void DeleteUser(int userid)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM Users WHERE userid=@userid";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { userid = userid });
            }
        }
    }
}
