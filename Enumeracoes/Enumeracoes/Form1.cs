using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracoes
{
    public partial class Form1 : Form
    {
        teste jogador = new teste();
        

        public Form1()
        {
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void cmd_cima_Click(object sender, EventArgs e)
        {
          jogador.Mover(teste.Movimentos.Cima);
        }

        private void cmd_direita_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Movimentos.Direita);
        }

        private void cmd_baixo_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Movimentos.Baixo);
        }

        private void cmd_esquerda_Click(object sender, EventArgs e)
        {
            jogador.Mover(teste.Movimentos.Esquerda);
        }
    }
}
