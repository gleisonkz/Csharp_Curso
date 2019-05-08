using System;
using System.IO;
using System.Data.SqlServerCe;
using System.Data;

namespace AgendaSQL
{
    public static partial class Vars
    {
        public static string versao = "v1.0.0";
        public static string folderBancoDeDados;
        public static string pathBancoDeDados;

        public static void Iniciar()
        {
            folderBancoDeDados = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\AgendaSQL\";

            //Verificar se a pasta com o banco de dados existe, caso contrário ele cria.

            try
            {
                if (!Directory.Exists(folderBancoDeDados))
                    Directory.CreateDirectory(folderBancoDeDados);

                pathBancoDeDados = folderBancoDeDados + "dados.sdf";
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                //Verificar se o banco de dados existe, caso contrário ele cria.
                if (!File.Exists(pathBancoDeDados))
                    CriarBaseDados();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void CriarBaseDados()
        {
            //Método para a criação do banco de dados.
            SqlCeEngine eg = new SqlCeEngine($"Data source = {pathBancoDeDados}");
            eg.CreateDatabase();

            var query = $"CREATE TABLE {"Contatos"} (" +
                        "ContatoID      INT NOT NULL PRIMARY KEY IDENTITY," +
                        "Nome           NVARCHAR(50) NOT NULL," +
                        "Telefone       INT NOT NULL)," +
                        "DtAtualizacao  DATETIME)";
            try
            {
                //Cria a estrutura da base de dados.
                SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
                SqlCeCommand command = new SqlCeCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }               
    }
}



