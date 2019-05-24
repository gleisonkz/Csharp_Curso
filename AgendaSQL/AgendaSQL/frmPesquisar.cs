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
    public partial class frmPesquisar : Form
    {
        public string textoPesquisa { get; set; }
        public bool cancelado { get; set; }

        //==============================================================================================================

        public frmPesquisar()
        {
            InitializeComponent();
        }

        //==============================================================================================================

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        //==============================================================================================================

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //Verificar se todos os campos foram preenchidos.
            if (textbox_pesquisa.Text.IsNullOrEmpty())
            {
                MessageBox.Show("É necessário informar a palavra a ser pesquisada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            textoPesquisa = textbox_pesquisa.Text;
            this.Close();
        }

        //==============================================================================================================
    }
}
