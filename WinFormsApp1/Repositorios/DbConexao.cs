using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1.Repositorios
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection _connection;

        public DbConexao()
        {
            string connectionString = "Server=DESKTOP-TDEFNQP\\SQLEXPRESS;Database=teste;Trusted_Connection=True;";            SqlConnection _connection = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            _connection?.Dispose();
        }

        public IDbConnection GetConnection()
        {
            if(_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            return _connection;
        }
    }
}
