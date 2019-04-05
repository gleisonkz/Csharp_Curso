using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //VARIAVEIS NUMERICAS

            ////byte = 1 byte = 0 a 255
            //byte idade = 45; 

            //// short = 2 bytes = -32.768 to 32.767
            //short idade2 = 45;

            //// int = 4 bytes = -2.147.483.648 to 2.147.483.647
            //int idade_planeta = 234982347;

            //// long = = 8 bytes -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            //long valor_enorme = 3245683746354;

            //// COM CASAS DECIMAIS

            //float valor1 = 1.5f;
            //double valor2 = 1.5d;
            //decimal valor3 = 1.5m;

            //ALFANUMERICAS

            string resultado = "João Ribeiro";
            char caracter1 = 'a';
            bool decisao = false;




            caixa_texto.Text = resultado;

           
        }


    }
}

