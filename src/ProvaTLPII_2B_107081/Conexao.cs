using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTLPII_2B_107081
{
    using System.Data.SqlClient;

    public static class Conexao
    {
        private static string connectionString = @"Server=.;Database=ProvaTLPII_2B_107081;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

}