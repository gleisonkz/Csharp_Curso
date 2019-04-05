using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_calcular_Click(object sender, EventArgs e)
        {
            //Executa o calculo da operação

            int parcela1, parcela2;
            string tipo_operacao;
            string algoritmo = text_operacao.Text;

            //123+456

            string sinais = "+-*/";

            int index = 0;
            foreach (char c in algoritmo)
            {
                foreach (char s in sinais)
                {
                    if (c == s)
                    {
                        // define os tres elementos da operacao
                        parcela1 = int.Parse(algoritmo.Substring(0, index ));
                        tipo_operacao = s.ToString();
                        parcela2 = int.Parse(algoritmo.Substring(index + 1));
                        
                    }
                }

                index++;
            }

        }
    }
}
