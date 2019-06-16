using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorBD
{


    public partial class Form1 : Form
    {
        //===========================================================================================================

        public static string dataBaseName = "loja.sdf";
        string pathDataBase = $"{AppDomain.CurrentDomain.BaseDirectory.ToString()}{dataBaseName}";

        //===========================================================================================================

        public Form1()
        {


            InitializeComponent();
        }

        //===========================================================================================================

        private void BtnCriarBaseDeDadosClick(object sender, EventArgs e)
        {
            GestorBD gestorBD = new GestorBD();

            List<string> parametros = new List<string>()
            {
                "CREATE TABLE Clientes(",
                "ClienteID     int not null identity(1,1) primary key,",
                "Nome          nvarchar(50),",
                "Telefone      nvarchar(10),",
                "DtAtualizacao datetime)",
                "FIM",

                "CREATE TABLE Compras(",
                "CompraID     int not null identity (1,1) primary key,",
                "ClienteID    int not null,",
                "QtdProduto      int,",
                "ValorUnitario      float,",
                "DtCriacao datetime," +
                "FOREIGN KEY(ClienteID) REFERENCES Clientes(ClienteID) ON DELETE CASCADE)",
                "FIM",
            };

            gestorBD.CriarBaseDados(pathDataBase, parametros, true);
        }

        //===========================================================================================================

        private void BtnSelectClick(object sender, EventArgs e)
        {


            List<GestorBD.SQLParametro> parametros = new List<GestorBD.SQLParametro>();
            parametros.Add(new GestorBD.SQLParametro("@Nome", textBox1.Text));

            string query = "SELECT * FROM Clientes WHERE nome = @Nome";

            GestorBD gestorBD = new GestorBD(pathDataBase);
            var dados = gestorBD.Select(query, parametros);






        }

        //===========================================================================================================

        private void button3_Click(object sender, EventArgs e)
        {
            List<GestorBD.SQLParametro> parametros = new List<GestorBD.SQLParametro>();
            parametros.Add(new GestorBD.SQLParametro("@Nome", "Carlos"));
            parametros.Add(new GestorBD.SQLParametro("@Telefone", 35462846));
            parametros.Add(new GestorBD.SQLParametro("@DataCriacao", DateTime.Now.ToString("yyyy-MM-dd")));

            string query = "INSERT INTO Clientes (Nome,Telefone,DtAtualizacao) VALUES (" +
                 "@Nome," +
                 "@Telefone," +
                $"@DataCriacao)";

            GestorBD gestorBD = new GestorBD(pathDataBase);
            gestorBD.ExecuteNonQuery(query, parametros);
            MessageBox.Show("Query Executada!");
        }

        //===========================================================================================================

        private void BtnInsertItem_Click(object sender, EventArgs e)
        {
            if (TextBoxInsertNome.Text  == "" || TextBoxInsertTelefone.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos.");
                return;
            }


                List<GestorBD.SQLParametro> parametros = new List<GestorBD.SQLParametro>();
                parametros.Add(new GestorBD.SQLParametro("@Nome", TextBoxInsertNome.Text));
                parametros.Add(new GestorBD.SQLParametro("@Telefone", TextBoxInsertTelefone.Text));
                parametros.Add(new GestorBD.SQLParametro("@DataCriacao", DateTime.Now.ToString("yyyy-MM-dd")));

                string query = "INSERT INTO Clientes (Nome,Telefone,DtAtualizacao) VALUES (" +
                     "@Nome," +
                     "@Telefone," +
                    $"@DataCriacao)";

                GestorBD gestorBD = new GestorBD(pathDataBase);
                gestorBD.ExecuteNonQuery(query, parametros);

        }

        //===========================================================================================================

        private void BtnCriarDataTable_Click(object sender, EventArgs e)
        {
            try
            {
                GestorBD gestorBD = new GestorBD(pathDataBase);
                DataTable dt = gestorBD.CriarTempTable("SELECT * FROM Clientes");

                // Alterações necessárias

                foreach (DataRow item in dt.Rows)
                {
                    string novoTelefone = $"(31) {item["Telefone"]}";
                    item["Telefone"] = novoTelefone;
                    item["DtAtualizacao"] = DateTime.Now;
                }

                gestorBD.GravarTempTable(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Executado com sucesso!");
        }

        //===========================================================================================================

        private void BtnInsertBatch_Click(object sender, EventArgs e)
        {
            //Utilização da classe Gestor para a inserção de varios registros.
                       
            List<Tuple<string, string>> lista = new List<Tuple<string, string>>()
            {
              new Tuple<string, string>("Renato","32705489"),
              new Tuple<string, string>("Adalgisa","47642945"),
              new Tuple<string, string>("Demagister","21457839"),
              new Tuple<string, string>("JaderFingers","23847549"),
              new Tuple<string, string>("Domo","23847504")
            };

            GestorBD gestorBD = new GestorBD(pathDataBase);
            DataTable dataTable = gestorBD.CriarTempTable("SELECT * FROM Clientes WHERE ClienteID = -1");

            foreach (var item in lista)
            {
                DataRow linha = dataTable.NewRow();
                linha["Nome"] = item.Item1;
                linha["Telefone"] = item.Item2;
                linha["DtAtualizacao"] = DateTime.Now;
                dataTable.Rows.Add(linha);
            };

            for (int i = 0; i < 100; i++)
            {
                gestorBD.GravarTempTable(dataTable);
            }

            



            MessageBox.Show("Concluído");

        }

        private void BtnCompactar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorBD gestorBD = new GestorBD(pathDataBase);
                gestorBD.CompactarBaseDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show("Base de dados compactada com sucesso");
        }

        //===========================================================================================================
    }
}
