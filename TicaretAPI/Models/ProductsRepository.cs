using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace TicaretAPI.Models
{
    public class ProductsRepository
    {
        private string connectionString;

        public ProductsRepository()
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

        public IEnumerable<ProductsWithStore> GetAllProduct()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"Select p.Id,p.Name,p.Quantity,p.Price,p.ImageUrl,p.Description,p.groupid,s.groupname 
                                FROM Products p INNER JOIN Store s on p.groupid=s.groupid";
                dbConnection.Open();
                return dbConnection.Query<ProductsWithStore>(sQuery);
            }
        }

        public ProductsWithStore GetByProduct(int Id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                //string sQuery = @"Select p.Id,p.Name,p.Quantity,p.Price,p.ImageUrl,p.Description,p.groupid,s.groupname 
                //                FROM Products p INNER JOIN Store s on p.groupid=s.groupid";
                string sQuery = @"SELECT * FROM Products p INNER JOIN Store s ON p.groupid=s.groupid WHERE Id=@Id";
                dbConnection.Open();
                return dbConnection.Query<ProductsWithStore>(sQuery, new { Id = Id }).FirstOrDefault();
            }
        }

        public ProductsWithStore SearchProduct(int Id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"Select 
                                FROM Products p INNER JOIN Store s on p.groupid=s.groupid";
                dbConnection.Open();
                return dbConnection.Query<ProductsWithStore>(sQuery, new { Id = Id }).FirstOrDefault();
            }
        }

        public void AddProduct(Products product)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Products (Name,Quantity,Price,ImageUrl,Description,groupid) 
                                VALUES(@Name,@Quantity,@Price,@ImageUrl,@Description,@groupid)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, product);
            }
        }
        public void UpdateProduct(int Id,ProductsWithStore products)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Products SET Name=@Name,Quantity=@Quantity,Price=@Price,ImageUrl=@ImageUrl,Description=@Description,groupid=@groupid
                                WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, products);
            }
        }
        public void DeleteProduct(int Id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM Products WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = Id });
            }
        }
    }
}
