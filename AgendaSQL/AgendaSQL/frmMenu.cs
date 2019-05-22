using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgendaSQL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //Apresenta a versão do software.
            label_versao.Text = Vars.versao;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            if (MessageBox.Show("Tem certeza que deseja sair ?",
                "Sair!",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                   return;
              Application.Exit();      
    }

        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarEditar frmAdicionarEditar = new frmAdicionarEditar();
            frmAdicionarEditar.ShowDialog();
        }

        private void cmd_visualizar_tudo_Click(object sender, EventArgs e)
        {
            frmResultados fr = new frmResultados();
            fr.ShowDialog();
            
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar f = new frmPesquisar();
            f.ShowDialog();

            if (f.cancelado)
            {
                f.Dispose();
                return;
            }

            string query = $"SELECT * FROM Contatos WHERE Nome LIKE'%{f.textoPesquisa}%' or Telefone LIKE'%{f.textoPesquisa}%'";

            frmResultados fr = new frmResultados(query);
            fr.ShowDialog();
        }
    }
}
