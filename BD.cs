using System;
using System.Configuration;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace INFOMASTER
{
    public class BD
    {
        public static int ExecutarSQL(string SQL)
        {
            string conexaoString = ConstruirStringConexao();
            using (FbConnection conexao = new FbConnection(conexaoString))
            {
                conexao.Open();
                using (FbCommand cmd = new FbCommand(SQL, conexao))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }

       






        public static void TestarConexao()
        {
            string conexaoString = ConstruirStringConexao();
            using (FbConnection conexao = new FbConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                }
                catch (FbException ex)
                {
                    Console.WriteLine("Erro na conexão: " + ex.Message);
                }
            }
        }

        private static string ConstruirStringConexao()
        {
            string banco = ConfigurationManager.AppSettings["Banco"];
            string servidor = ConfigurationManager.AppSettings["Servidor"];
            string porta = ConfigurationManager.AppSettings["Porta"];
            string usuario = "SYSDBA";
            string senha = "masterkey";

            // Construa a string de conexão
            string conexaoString = $"User={usuario};Password={senha};Database={banco};DataSource={servidor};Port={porta}";
            return conexaoString;
        }
    }
}
