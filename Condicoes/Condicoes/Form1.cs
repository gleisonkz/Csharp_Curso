using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            int valor = 50;

            if (valor < 5)
            {
                label_resultado.Text = "Valor < 5";
            }
            else if (valor < 10)
            {
                label_resultado.Text = "Valor < 10";
            }
            else if (valor < 15)
            {
                label_resultado.Text = "Valor < 15";
            }
            else
            {
                label_resultado.Text = "Não deu!";
            }

        }
    }
}
