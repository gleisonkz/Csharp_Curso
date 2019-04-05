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
    public partial class frmUm : Form
    {



        public frmUm()
        {
            InitializeComponent();
            label_resultado_final.Text = geral.nome;

        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Esta janela irá fechar. Deseja continuar?", "Atenção", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            this.Close();
        }

        private void frmUm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_copia.Text = geral.nome;
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            label_copia.Text = string.Empty;
            label_copia.Text = "";
        }

        private void label_resultado_final_Click(object sender, EventArgs e)
        {

        }
    }
}
