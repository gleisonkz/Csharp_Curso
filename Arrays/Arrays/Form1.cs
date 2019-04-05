using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {

            //ARRAYS

            // PARA QUALQUER ARRAY O ÍNDICE SEMPRE COMEÇA COM A POSIÇÃO 0

            int[] valores = new int[5];

            valores[0] = 10;
            valores[1] = 20;
            valores[2] = 30;
            valores[3] = 40;
            valores[4] = 50;

            int resultado = valores[0] + valores[3];
            lista.Items.Add(resultado);



            int[] valores = new int[] { 10, 30, 50, 80, 90, 20, 30, 40, 50, 70, 80, 60, 90 };


            for (int cont = 0; cont < valores.Length; cont++)
                lista.Items.Add(valores[cont]);




            //foreach (int valor in valores)
            //    lista.Items.Add(valor);













        }
    }
}
