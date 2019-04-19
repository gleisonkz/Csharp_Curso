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
    public partial class frmInserirEditar : Form
    {
        public frmInserirEditar()
        {
            InitializeComponent();
            CarregarDadosLista();

        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarDadosLista()
        {
            //Adiciona a ListBox os contatos existentes na lista

            LB_lista_contatos.Items.Clear();

            foreach (contato item in Geral.listaDeContatos)
            {
                LB_lista_contatos.Items.Add($"{item.nome.PadRight(25)} ({int.Parse(item.numero).ToString(@"0000-0000")})");
            }

            label_numero_registros.Text = $"Qtd Registros: {LB_lista_contatos.Items.Count}";
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //Verifica se todos os campos foram preenchidos

            if (text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("É necessario que todos os campos estejam preenchidos");
                return;
            }

            if (text_numero.Text.Length < 8)
            {
                MessageBox.Show("É necessario que o telefone tenha no mínimo 8 dígitos");
                return;
            }


            if (Geral.VerificaDulicidadeContato(text_nome.Text.ToUpper(), text_numero.Text))
            {
                MessageBox.Show("Já existe um contato registrado com este Nome e Numero.");
                return;
            }
                                             
            Geral.InserirContatoLista(text_nome.Text.ToUpper(), text_numero.Text);
            CarregarDadosLista();
            text_nome.Text = String.Empty;
            text_numero.Text = String.Empty;
            text_nome.Focus();
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja apagar o registro ?", "Atenção!",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Geral.ApagaContadoLista(LB_lista_contatos.SelectedIndex);
                CarregarDadosLista();
                text_nome.Focus();
            }

        }

        private void LB_lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }
    }
}
