using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {

            var calculadora = new cl_calculo();

            int preco_inicial = int.Parse(caixa_preco.Text);
            int tipo_produto = 0;

            if (rd1.Checked) { tipo_produto = 1; }
            else if (rd2.Checked) { tipo_produto = 2; }
            else if (rd3.Checked) { tipo_produto = 3; }




            MessageBox.Show("Preço Final " + calculadora.CalcularPrecoFinal(preco_inicial,tipo_produto));
        }
    }
}
