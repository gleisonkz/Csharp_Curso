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

        //==============================================================================================================

        public frmAdicionarEditar(int contatoID = -1)
        {
            InitializeComponent();
            this.contatoID = contatoID;
            editar = (contatoID == -1) ? false : true;
        }

        //==============================================================================================================

        private void BtnGravarClick(object sender, EventArgs e)
        {
            //Grava ou atualiza o registro

            #region Validações
            //Verificar se todos os campos foram preenchidos.
            if (text_nome.Text.IsNullOrEmpty() || text_telefone.Text.IsNullOrEmpty())
            {
                MessageBox.Show("É necesário que todos os campos estejam preenchidos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }






            #endregion

            #region GravarRegistro

            if (editar == false)
            {
                try
                {
                    Vars.InsertBaseDados(text_nome.Text, int.Parse(text_telefone.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} \nOperação Cancelada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Registro Inserido com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                text_nome.Text = null;
                text_telefone.Text = null;
                text_nome.Focus();
            }

            #endregion

            #region AtualizarRegistro

            if (editar)
            {
                try
                {
                    Vars.AtualizarContato(contatoID, text_nome.Text, int.Parse(text_telefone.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} \nOperação Cancelada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Registro Atualiado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                
            }

            #endregion
        }

        //==============================================================================================================

        private void BtnFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        private void FrmAdicionarEditar_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                try
                {
                    var dados = Vars.BuscarContato(contatoID);
                    text_nome.Text = dados.Rows[0]["Nome"].ToString();
                    text_telefone.Text = Convert.ToInt32(dados.Rows[0]["Telefone"]).ToString(); ;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

        }

        //==============================================================================================================

    }
}
