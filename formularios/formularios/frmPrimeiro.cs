using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios
{
    public partial class frmPrimeiro : Form
    {
        public frmPrimeiro()
        {
            InitializeComponent();
        }

        private void cmd_um_Click(object sender, EventArgs e)
        {
            geral.nome = text_nome.Text;
            frmUm formulario = new frmUm();
            formulario.ShowDialog();
            
        }

        private void cmd_dois_Click(object sender, EventArgs e)
        {
            frmDois formulario = new frmDois();
            formulario.ShowDialog();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
