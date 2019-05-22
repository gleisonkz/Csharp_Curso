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

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            Vars.IniciarGrid(grid_resultados, query);
            grid_resultados.ClearSelection();
            label_registros.Text = $"Qtd registros: {grid_resultados.Rows.Count.ToString()}";
        }

        private void btn_apagar_Click(object sender, EventArgs e)
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

        private void grid_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            contatoID = Convert.ToInt16(grid_resultados.Rows[e.RowIndex].Cells["ContatoID"].Value);
            btn_apagar.Enabled = true;
            btn_editar.Enabled = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            frmAdicionarEditar frmAdicionarEditar = new frmAdicionarEditar(contatoID);
            frmAdicionarEditar.ShowDialog();
            Vars.IniciarGrid(grid_resultados);
            grid_resultados.ClearSelection();
            contatoID = -1;
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vars.IniciarGrid(grid_resultados);
            grid_resultados.ClearSelection();
            contatoID = -1;
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;
        }
    }
}
