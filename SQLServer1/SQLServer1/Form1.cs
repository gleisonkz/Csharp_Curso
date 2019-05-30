using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server = DESKTOP-8FJ23CQ\LOCALDB; Database = SQL_TESTE; Trusted_Connection = True";
            connection.Open();

            var query = "CREATE TABLE Contatos" +
                        "(" +
                        "ContatoID int NOT NULL PRIMARY KEY," +
                        "Nome varchar(50) NOT NULL," +
                        "Telefone varchar(10) NOT NULL," +
                        "DataCriacao datetime," +
                        "DataAtualizacao datetime);";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Tabela Criada!");
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server = DESKTOP-8FJ23CQ\LOCALDB; Database = SQL_TESTE; Trusted_Connection = True";
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.Parameters.AddWithValue("@ContatoID", 1);
            command.Parameters.AddWithValue("@Nome", "Carlos");
            command.Parameters.AddWithValue("@Telefone", "327033694");
            command.Parameters.AddWithValue("@DataCriacao", DateTime.Now);
            command.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);

            command.CommandText = "INSERT INTO Contatos VALUES(" +
                "@ContatoID, @Nome, @Telefone, @DataCriacao,@DataAtualizacao)";


            command.ExecuteNonQuery();
            command.Dispose();
            connection.Dispose();
            MessageBox.Show("Contato Criado!");


        }
    }
}
