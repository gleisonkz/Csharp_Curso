using System;
using System.IO;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace AgendaSQL
{
    public static partial class Vars
    {
        public static string versao = "v1.0.0";
        public static string folderBancoDeDados;
        public static string pathBancoDeDados;

        //==============================================================================================================

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
                MessageBox.Show(ex.Message);
            }
        }

        //==============================================================================================================

        public static void ExecuteSQL(string query, SqlCeCommand command, SqlCeConnection connection)
        {
            try
            {
                command.CommandText = query;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Dispose();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //==============================================================================================================

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

            SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
            SqlCeCommand command = new SqlCeCommand(query, connection);

            ExecuteSQL(query, command, connection);
        }

        //==============================================================================================================

        public static void InsertBaseDados(string nome, int telefone)
        {

            var query = $"INSERT INTO Contatos (Nome,Telefone,DtAtualizacao)" +
                $" VALUES (" +
                $"@nome," +
                $"@telefone," +
                $"GETDATE())";

            SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@telefone", telefone);

            //Verifica se o contato a ser adicionado já existe no banco.
            var adapter = new SqlCeDataAdapter();
            var DT = new DataTable();
            command.CommandText = $"SELECT* FROM Contatos WHERE Nome = @nome AND Telefone = @telefone";
            adapter.SelectCommand = command;
            adapter.Fill(DT);

            if (DT.Rows.Count == 0)
            {
                ExecuteSQL(query, command, connection);
            }
            else
            {
                throw new Exception("Este contato já existe na base de dados");
            }
        }

        //==============================================================================================================

        public static DataTable BuscarContato(int contatoID)
        {
            SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
            SqlCeDataAdapter adapter = new SqlCeDataAdapter($"SELECT* FROM Contatos WHERE ContatoID = {contatoID}", connection);
            var DT = new DataTable();
            connection.Open();
            adapter.Fill(DT);
            adapter.Dispose();
            connection.Dispose();
            return DT;
        }

        //==============================================================================================================
        public static void AtualizarContato(int contatoID, string nome, int telefone)
        {
            var query = $"UPDATE Contatos " +
                        $"SET Nome = @nome," +
                        $" Telefone = @telefone," +
                        $" DtAtualizacao = GETDATE() " +
                        $"WHERE ContatoID = @contatoID";

            SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
            SqlCeCommand command = new SqlCeCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@telefone", telefone);
            command.Parameters.AddWithValue("@contatoID", contatoID);

            //Verifica se o contato a ser adicionado já existe no banco.
            var DT = new DataTable();
            command.CommandText = "SELECT* FROM Contatos WHERE nome = @nome AND Telefone = @telefone AND ContatoID <> @contatoID";
            var adapter = new SqlCeDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(DT);

            if (DT.Rows.Count == 0)
            {
                ExecuteSQL(query, command, connection);
            }
            else
            {
                throw new Exception("Este contato já existe na base de dados para outro ID");
            }


        }

        //==============================================================================================================

        public static void ApagarContato(int contatoID)
        {
            var query = $"DELETE FROM Contatos " +
                        $"WHERE ContatoID = @contatoID";

            SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.Parameters.AddWithValue("@contatoID", contatoID);
            ExecuteSQL(query, command, connection);

        }

        //==============================================================================================================
        public static void IniciarGrid(DataGridView gridView, string queryP = "")
        {
            if (queryP == "")
            {
                string query = "SELECT* FROM Contatos";

                SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
                connection.Open();

                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                var DT = new DataTable();
                adapter.Fill(DT);
                gridView.DataSource = DT;
                adapter.Dispose();
                connection.Dispose();

            }
            else
            {
                string query = queryP;

                SqlCeConnection connection = new SqlCeConnection($@"Data source = {pathBancoDeDados}");
                connection.Open();

                SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
                var DT = new DataTable();
                adapter.Fill(DT);
                gridView.DataSource = DT;
                adapter.Dispose();
                connection.Dispose();

            }

        }

        //==============================================================================================================
    }
}



