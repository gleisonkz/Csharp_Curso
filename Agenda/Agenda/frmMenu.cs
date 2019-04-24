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

            //Carrega a lista de contatos
            Geral.AtualizaListaDeContatos();

            //Apresenta a versão do programa
            label_versao.Text = Geral.versao;
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
            Geral.AtualizaListaDeContatos();
            var frmInserirEditar = new frmInserirEditar();
            frmInserirEditar.ShowDialog();
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //Abrir um quadro de pesquisa

            var form_pesquisa = new frmTexto();
            form_pesquisa.ShowDialog();

            //Quando o quadro for fechado, verificar se foi cancelado

            if (form_pesquisa.cancelado)
            {
                return;
            }

            var form_results = new frmResultado(form_pesquisa.texto);
            form_results.ShowDialog();

        }
    }
}
