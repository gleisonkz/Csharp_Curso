﻿using System;
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
        public frmAdicionarEditar()
        {
            InitializeComponent();
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            Vars.InsertBaseDados(text_nome.Text, int.Parse(text_telefone.Text));
            MessageBox.Show("Dados Inseridos com sucesso!");
                
        }
    }
}