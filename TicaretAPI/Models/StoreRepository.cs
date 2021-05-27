using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TicaretAPI.Models
{
    public class StoreRepository
    {
        private string connectionString;

        public StoreRepository()
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

        public IEnumerable<Store> GetAllStore()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Store";
                dbConnection.Open();
                return dbConnection.Query<Store>(sQuery);
            }
        }

        public Store GetByStore(int groupid)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Store WHERE groupid=@groupid";
                dbConnection.Open();
                return dbConnection.Query<Store>(sQuery, new { groupid = groupid }).FirstOrDefault();
            }
        }

        public void AddStore(Store store)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Store (groupname) VALUES(@groupname)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, store);
            }
        }

        public void UpdateStore(Store store)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Store SET groupname=@groupname 
                                WHERE groupid=@groupid";
                dbConnection.Open();
                dbConnection.Execute(sQuery, store);
            }
        }
        public void DeleteStore(int groupid)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM Store WHERE groupid=@groupid";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { groupid = groupid });
            }
        }
    }
}
