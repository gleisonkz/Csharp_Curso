using System;
using System.IO;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace AgendaSQL
{
    public static partial class Vars2
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //Verificar se o banco de dados existe, caso contrário ele cria.
                if (!File.Exists(pathBancoDeDados))
                    CriarBaseDados();
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                MessageBox.Show(erro);
            }
        }

        public static void ExecuteSQL(string query, params SqlCeParameter[] parameters)
        {
            try
            {
                SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
                SqlCeCommand command = new SqlCeCommand(query, connection);


                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

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

        public static void CriarBaseDados()
        {
            //Método para a criação do banco de dados.
            SqlCeEngine eg = new SqlCeEngine($"Data source = {pathBancoDeDados}");
            eg.CreateDatabase();

            var query = $"CREATE TABLE {"Contatos"} (" +
                        "ContatoID      INT NOT NULL PRIMARY KEY IDENTITY," +
                        "Nome           NVARCHAR(50) NOT NULL," +
                        "Telefone       INT NOT NULL," +
                        "DtAtualizacao  DATETIME)";

            ExecuteSQL(query);
        }

        public static SqlCeParameter CriarParametro(string nameVar, object valor, SqlDbType tipo, int tamanho)
        {
            SqlCeParameter parametro = new SqlCeParameter($"@{nameVar}", tipo, tamanho);
            parametro.Value = valor;
            return parametro;

        }

        public static void InsertBaseDados(string nome, int telefone)
        {
            var p1 = CriarParametro("nome", nome, SqlDbType.NVarChar, 50);
            var p2 = CriarParametro("telefone", telefone, SqlDbType.Int, 8);

            var query = $"INSERT INTO Contatos (Nome,Telefone,DtAtualizacao)" +
                $" VALUES (" +
                $"@nome," +
                $"@telefone," +
                $"GETDATE())";

            ExecuteSQL(query, p1, p2);
        }

        public static void BuscarContato(int contatoID)
        {
            var query = $"SELECT* FROM Contatos WHERE ContatoID = @contatoID";
            var p1 = CriarParametro("contatoID", contatoID, SqlDbType.Int, 8);

            ExecuteSQL(query,p1);
        }

        public static void AtualizarContato(int contatoID, string nome, int telefone)
        {
            var query = $"UPDATE Contatos " +
                        $"SET Nome = @nome, Telefone = @telefone, DtAtualizacao = GETDATE() " +
                        $"WHERE ContatoID = @contatoID";

            var p1 = CriarParametro("contatoID", contatoID, SqlDbType.Int, 8);
            var p2 = CriarParametro("nome", nome, SqlDbType.NVarChar, 50);
            var p3 = CriarParametro("telefone", telefone, SqlDbType.Int, 8);

            ExecuteSQL(query,p1,p2,p3);
        }

    }
}



