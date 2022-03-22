using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Repository
{
    public interface IReporitorieBooks
    {
        void Create(Book book);
    }
    public class RepositorieBooks
    {
        private readonly string connectionString;

        public RepositorieBooks(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public void Create(Book book)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO Books 
                                                  (BookName, Author, Price)
                                                    Values(@BookName, @Author, @Price)", book);
        }
    }

}
