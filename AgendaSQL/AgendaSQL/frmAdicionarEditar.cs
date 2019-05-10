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
    public partial class frmAdicionarEditar : Form
    {
        int contatoID;
        bool editar;
        
        public frmAdicionarEditar(int contatoID = -1)
        {
            InitializeComponent();
            this.contatoID = contatoID;
            editar = (contatoID == -1) ? false : true;
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //Grava ou atualiza o registro

 
            if (text_nome.Text.IsNullOrEmpty() || text_telefone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("É necesário que todos os campos estejam preenchidos");
                return;
            }

            #region GravarRegistro

            if (editar == false)
            {
                Vars.InsertBaseDados(text_nome.Text, int.Parse(text_telefone.Text));
                MessageBox.Show("Dados Inseridos com sucesso!");
                text_nome.Text = null;
                text_telefone.Text = null;
                text_nome.Focus(); 
            }

            #endregion

            #region AtualizarRegistro

            if (editar)
            {
                Vars.AtualizarContato(contatoID, text_nome.Text, int.Parse(text_telefone.Text));
                MessageBox.Show("Dados Inseridos com sucesso!");
                text_nome.Text = null;
                text_telefone.Text = null;
                text_nome.Focus(); 
            }

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                Vars.BuscarContato(contatoID);
            }
        }

    }
}
