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
            int? resultado = null;
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
                        parcela1 = int.Parse(algoritmo.Substring(0, index));
                        tipo_operacao = s.ToString();
                        parcela2 = int.Parse(algoritmo.Substring(index + 1));
                        // analisa o tipo de operação que será realizada

                        switch (tipo_operacao)
                        {
                            case "+": // realiza a adição
                                {
                                    resultado = parcela1 + parcela2;
                                    break;
                                }

                            case "-": // realiza a subtração
                                {
                                    resultado = parcela1 + parcela2;
                                    break;
                                }
                            case "*": // realiza a multiplicação
                                {
                                    resultado = parcela1 + parcela2;
                                    break;
                                }
                            case "/": // realiza a divisão
                                {
                                    resultado = parcela1 + parcela2;
                                    break;
                                }
                        }
                        break;
                    }
                }
                if (resultado != null)
                {
                    break;
                }
                index++;
            }

            //apresenta o resultado final da operação
            MessageBox.Show($"O resultado da operação {algoritmo} é = {resultado}");

            //Limpa a caixa de texto
            text_operacao.Text = null;
            // Volta o tab index para a caixa de texto
            text_operacao.Focus();
            
        }

        private void text_operacao_KeyDown(object sender, KeyEventArgs e)
        {
            //Ao clicar a tecla Enter ou Return, executa a operação
            //exeto no caso de não existir texto.

            //Verifica se existe texto

            if (text_operacao.Text == null || text_operacao.Text == "")
            {
                return;
            }

            //Analisa se foi pressionada a tecla Enter

            if (e.KeyCode == Keys.Return)
            {
                cmd_calcular_Click(cmd_calcular, EventArgs.Empty);
                
            }

        }
    }
}

