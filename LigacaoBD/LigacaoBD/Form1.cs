using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace LigacaoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Faz a seleção de todos os dados contidos no banco de dados

            try
            {
                //Conectar a Base de Dados
                SqlCeConnection conexao = new SqlCeConnection();
                conexao.ConnectionString = $@"Data Source = C:\Csharp\{text_bd.Text}.sdf";
                conexao.Open();

                //Selecação dos dados do BD para a Mémoria
                var dados = new DataTable();
                var adaptador = new SqlCeDataAdapter("SELECT * FROM Pessoas", conexao);
                adaptador.Fill(dados);

     

                //Desconecta da Base de Dados

                conexao.Close();

                //Apresenta os dados na lista
                lista_dados.Items.Clear();
                foreach (DataRow linha in dados.Rows)
                {
                    lista_dados.Font = new Font("Courier New", 8.25F, FontStyle.Regular);

                    lista_dados.Items.Add(linha["Nome"].ToString().PadRight(30) +
                                          linha["Morada"].ToString().PadRight(30) +
                                          linha["Telefone"].ToString()
                          );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Inserção de um novo registro no banco de dados


            try
            {
                //Conectar a Base de Dados
                SqlCeConnection conexao = new SqlCeConnection();
                conexao.ConnectionString = $@"Data Source = C:\Csharp\{text_bd.Text}.sdf";
                conexao.Open();

                string query = "INSERT INTO Pessoas VALUES('Fabio Alexandre','Rua das oportunidades','987875316')";

                var adaptador = new SqlCeCommand(query, conexao);
                adaptador.ExecuteNonQuery();

                //Desconecta da Base de Dados

                conexao.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }
    }
}
