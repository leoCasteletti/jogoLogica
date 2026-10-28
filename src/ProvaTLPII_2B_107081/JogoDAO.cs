using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvaTLPII_2B_107081;
using Dapper;
using System.Data.SqlClient;

namespace ProvaTLPII_2B_107081
{
    public class JogoDAO
    {
        public void Inserir(Resultado resultado)
        {
            string sql = @"INSERT INTO Resultados (DataHora, NomeInformado, NumeroGerado, NumeroCorreto)
                       VALUES (@DataHora, @NomeInformado, @NumeroGerado, @NumeroCorreto)";

            using (var connection = Conexao.GetConnection())
            {
                connection.Execute(sql, resultado);
            }
        }

        public List<Resultado> ListarTodos()
        {
            string sql = "SELECT ID, DataHora, NomeInformado, NumeroGerado, NumeroCorreto FROM Resultados ORDER BY DataHora DESC";

            using (var connection = Conexao.GetConnection())
            {
                return connection.Query<Resultado>(sql).ToList();
            }
        }
    }
}




