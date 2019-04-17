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
            InserirDadosLista();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInserirEditar_Load(object sender, EventArgs e)
        {
            
        }

        private void InserirDadosLista()
        {
            //Adiciona a lista de contatos os registros

            lista_contatos.Items.Clear();

            foreach (contato item in geral.listaDeContatos)
            {
                lista_contatos.Items.Add($"{item.nome} ({item.numero})");
            }

            label_numero_registros.Text = $"Qtd Registros: {lista_contatos.Items.Count}";
        }

    }
}
