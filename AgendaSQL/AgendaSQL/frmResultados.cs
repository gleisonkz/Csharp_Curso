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
    public partial class frmResultados : Form
    {
        int contatoID;
        private readonly string query;

        public frmResultados(string query = "")
        {
            this.query = query;
            InitializeComponent();
        }

        //==============================================================================================================

        private void BtnFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }

        //==============================================================================================================

        private void FrmResultadosLoad(object sender, EventArgs e)
        {
            Vars.IniciarGrid(grid_resultados, query);
            grid_resultados.ClearSelection();
            label_registros.Text = $"Qtd registros: {grid_resultados.Rows.Count.ToString()}";
        }

        //==============================================================================================================

        private void BtnApagarClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que desaja apagar o contato?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            try
            {
                Vars.ApagarContato(contatoID);
                MessageBox.Show("Registro Apagado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Vars.IniciarGrid(grid_resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} \nOperação Cancelada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //==============================================================================================================

        private void GridResultadosCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            contatoID = Convert.ToInt16(grid_resultados.Rows[e.RowIndex].Cells["ContatoID"].Value);
            BtnApagar.Enabled = true;
            BtnEditar.Enabled = true;
        }

        //==============================================================================================================

        private void BtnEditarClick(object sender, EventArgs e)
        {
            frmAdicionarEditar frmAdicionarEditar = new frmAdicionarEditar(contatoID);
            frmAdicionarEditar.ShowDialog();
            Vars.IniciarGrid(grid_resultados);
            grid_resultados.ClearSelection();
            contatoID = -1;
            BtnApagar.Enabled = false;
            BtnEditar.Enabled = false;

        }

        //==============================================================================================================

        private void BtnVerTudoClick(object sender, EventArgs e)
        {
            Vars.IniciarGrid(grid_resultados);
            grid_resultados.ClearSelection();
            contatoID = -1;
            BtnApagar.Enabled = false;
            BtnEditar.Enabled = false;
        }

        //==============================================================================================================
    }
}
