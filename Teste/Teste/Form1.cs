﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {


            ////int parcela_1 = int.Parse(text_parcela_1.Text);
            ////int parcela_2 = int.Parse(text_parcela_2.Text);
            ////int resultado;

            ////////adição (+)
            //////resultado = parcela_1 + parcela_2;

            ////////subtração (-)
            //////resultado = parcela_1 - parcela_2;

            ////////subtração (*)
            //////resultado = parcela_1 * parcela_2;

            ////////divisão (/)
            //////resultado = parcela_1 / parcela_2;

            ////////modulo (resto da divisão) (%)
            //////resultado = parcela_1 % parcela_2;

            //int resultado = 10;

            //////resultado = resultado + 1;
            ////resultado++;
            ////resultado = resultado + 5;
            ////resultado += 5;
            ///

            int resultado = 0;

      

            label_resultado.Text = resultado.ToString();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
