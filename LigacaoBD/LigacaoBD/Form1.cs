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

        private void btn_select_Click(object sender, EventArgs e)
        {
            #region Forma Ensinada No Video
            ////Faz a seleção de todos os dados contidos no banco de dados

            //try
            //{
            //    //Conectar a Base de Dados
            //    SqlCeConnection conexao = new SqlCeConnection();
            //    conexao.ConnectionString = $@"Data Source = C:\Csharp\{text_bd.Text}.sdf";
            //    conexao.Open();

            //    //Selecação dos dados do BD para a Mémoria
            //    var dados = new DataTable();
            //    var adaptador = new SqlCeDataAdapter("SELECT * FROM Pessoas", conexao);
            //    adaptador.Fill(dados);

            //    //Desconecta da Base de Dados
            //    conexao.Close();

            //    //Apresenta os dados na lista
            //    lista_dados.Items.Clear();
            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista_dados.Font = new Font("Courier New", 8.25F, FontStyle.Regular);

            //        lista_dados.Items.Add(linha["Nome"].ToString().PadRight(30) +
            //                              linha["Morada"].ToString().PadRight(30) +
            //                              linha["Telefone"].ToString()
            //              );
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //} 
            #endregion

            try
            {
                //Conectar a Base de Dados.
                SqlCeConnection conexao = new SqlCeConnection();
                conexao.ConnectionString = $@"Data Source = C:\Csharp\{text_bd.Text}.sdf";
                conexao.Open();

                //Criando o comando SQL.
                var sqlcecommand = new SqlCeCommand("SELECT * FROM Pessoas", conexao);

                //Criando um DataReader.
                var dr = sqlcecommand.ExecuteReader();

                //Atribuindo o Schema do banco no DataTable.
                var dt = dr.GetSchemaTable();

                lista_dados.Items.Clear();

                while (dr.Read())
                {
                    //Alteração da fonte da lista para uma fonte monoespaçada.
                    lista_dados.Font = new Font("Courier New", 8.25F, FontStyle.Regular);


                    var lst = dt.Rows.Cast<DataRow>().Select(c => dr[c[0].ToString()].ToString().PadRight(30));

                    var info = string.Join(string.Empty.PadRight(1), lst);

                    lista_dados.Items.Add(info);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //Inserção de um novo registro no banco de dados

            try
            {
                //Conectar a Base de Dados
                SqlCeConnection conexao = new SqlCeConnection();
                conexao.ConnectionString = $@"Data Source = C:\Csharp\{text_bd.Text}.sdf";
                conexao.Open();

                //String com a query a ser executada
                string query = $"INSERT INTO Pessoas VALUES('{tb_nome.Text}','{tb_morada.Text}','{tb_telefone.Text}')";

                var command = new SqlCeCommand(query, conexao);
                command.ExecuteNonQuery();

                //Desconecta da Base de Dados
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Deleta um registro no banco de dados

            try
            {
                //Conectar a Base de Dados
                SqlCeConnection conexao = new SqlCeConnection();
                conexao.ConnectionString = $@"Data Source = C:\Csharp\{text_bd.Text}.sdf";
                conexao.Open();

                //String com a query a ser executada
                string query = $"DELETE FROM Pessoas WHERE Nome = ('{tb_nome.Text}')";

                var command = new SqlCeCommand(query, conexao);
                command.ExecuteNonQuery();

                //Desconecta da Base de Dados
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Atualiza um registro no banco de dados

            try
            {
                //Conectar a Base de Dados
                SqlCeConnection conexao = new SqlCeConnection();
                conexao.ConnectionString = $@"Data Source = C:\Csharp\{text_bd.Text}.sdf";
                conexao.Open();

                //String com a query a ser executada
                string query = $"UPDATE Pessoas SET Nome = '{tb_nome.Text}' WHERE Nome = 'Mariana Correia'";

                var command = new SqlCeCommand(query, conexao);
                command.ExecuteNonQuery();

                //Desconectar da Base de Dados
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
