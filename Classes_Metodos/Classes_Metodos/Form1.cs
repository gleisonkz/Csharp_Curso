using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Metodos
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
            var calculadora = new cl_matematica();

            double valorTXT1, valorTXT2;

            valorTXT1 = Convert.ToDouble(textBox_valor1.Text);
            valorTXT2 = Convert.ToDouble(textBox_valor2.Text);

            label_adicao.Text = (calculadora.Operacoes(valorTXT1,valorTXT2,"adicao")).ToString();
            label_subtracao.Text = (calculadora.Operacoes(valorTXT1, valorTXT2,"subtracao")).ToString();
            label_divisao.Text = (calculadora.Operacoes(valorTXT1, valorTXT2, "divisao")).ToString();
            label_multiplicacao.Text = (calculadora.Operacoes(valorTXT1, valorTXT2, "multiplicacao")).ToString();

            
        }

        private void label_adicao_Click(object sender, EventArgs e)
        {

        }
    }
}
