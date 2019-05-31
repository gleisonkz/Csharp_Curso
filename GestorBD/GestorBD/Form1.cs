using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestorBD gestorBD = new GestorBD();

            List<string> parametros = new List<string>()
            {
                "CREATE TABLE Clientes(",
                "ClienteID     int not null primary key,",
                "Nome          nvarchar(50),",
                "Telefone      nvarchar(10),",
                "DtAtualizacao datetime)",
                "FIM",

                "CREATE TABLE Compras(",
                "CompraID     int not null primary key,",
                "ClienteID    int not null,",
                "QtdProduto      int,",
                "ValorUnitario      float,",
                "DtCriacao datetime," +
                "FOREIGN KEY(ClienteID) REFERENCES Clientes(ClienteID) ON DELETE CASCADE)",
                "FIM",
            };






            //gestorBD.CriarBaseDados(@"C:\Csharp\loja.sdf", parametros, true);

            gestorBD = new GestorBD(@"C:\Csharp\loja.sdf");
            gestorBD.Buscar("SELECT * FROM Clientes");
        }
    }
}
