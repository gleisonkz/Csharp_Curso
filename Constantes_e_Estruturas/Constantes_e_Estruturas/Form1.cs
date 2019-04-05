using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constantes_e_Estruturas
{
    public partial class Form1 : Form
    {
        struct estrutura_pessoa
        {
            public string Nome;
            public string Apelido;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal objeto1 = new normal();

            Console.WriteLine(objeto1.Nome);
            Console.WriteLine(estatica.Nome);

            var p1 = new pessoa();
            p1.Nome = "João";
            p1.Apelido = "Ribeiro";

            estrutura_pessoa p2 = new estrutura_pessoa();

            p2.Nome = "João";
            p2.Apelido = "Ribeiro";

            Console.WriteLine("{0} {1}",p2.Nome,p2.Apelido);


        }
    }
}
