using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estruturas_de_Repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {

            ////FOR

            //for (int valor = 0; valor <= 100; valor++)
            //{
            //    if (valor % 5 == 0)
            //    {
            //        lista.Items.Add(valor);
            //    }

            //}

            ////WHILE

            //int valor2 = 1;
            //while (valor2 <= 100)
            //{
            //    lista.Items.Add(valor2++);

            //}

            //// DO WHILE

            //int numero = int.Parse(textnumero.Text);
            //int cont = 1;

            //lista.Items.Clear();

            //do
            //{

            //    lista.Items.Add(numero + " X " + cont + " = " + numero*cont);
            //} while (cont++ < 10);

            // FOREACH

            //string frase = "Este ciclo é fantástico.";

            //List<string> lista_nomes = new List<string>()
            //{
            //    "Joao", "Antonio", "Francisco", "Carlos", "Ana", "Patricia", "Joana"
            //};
            //foreach (string s in lista_nomes )
            //{
            //    lista.Items.Add(s);
            //}

           







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
