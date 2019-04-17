using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            //Apresenta a versão do programa
            label_versao.Text = cl_geral.versao;
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação ?", "Atenção",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }   
        }

        private void cmd_inserir_Click(object sender, EventArgs e)
        {
            var frmInserirEditar = new frmInserirEditar();
            frmInserirEditar.ShowDialog();
        }
    }
}
