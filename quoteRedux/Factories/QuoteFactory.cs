using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using LoginReg.Models;
namespace LoginReg.Factory
{
    public class QuoteFactory : IFactory<Quote>
    {
        private string connectionString;
        public QuoteFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=888;database=qrdxdb;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }
        public void Add(Quote item, int? id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO quotes (contentField, created_at, updated_at, user_id) VALUES (@contentField, NOW(), NOW(), id)";
                dbConnection.Open();
                dbConnection.Execute(query, item);
            }
        }
        public IEnumerable<Quote> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Quote>("SELECT * FROM quotes ORDER BY created_at DESC");
            }
        }
        public Quote FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Quote>("SELECT * FROM quotes WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
    }
}