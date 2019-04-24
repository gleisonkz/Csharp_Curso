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
    public partial class frmResultado : Form
    {
        string texto;

        public frmResultado(string texto)
        {
            
            InitializeComponent();
            this.texto = texto.ToUpper();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {

            var lst = Geral.BuscarContatoLista(texto);
            lista_resultado_pesquisa.Items.Clear();

            foreach (var contato in lst)
            {
                lista_resultado_pesquisa.Items.Add($"{contato.nome.PadRight(25)} ({int.Parse(contato.numero).ToString(@"0000-0000")})");
            }

            label_numero_registros.Text = $"Qtd Registros: {lst.Count}";
        }

        private void cmd_nova_pesquisa_Click(object sender, EventArgs e)
        {

            
            //Abrir um quadro de pesquisa

            var form_pesquisa = new frmTexto();
            form_pesquisa.ShowDialog();

            //Quando o quadro for fechado, verificar se foi cancelado

            if (form_pesquisa.cancelado)
            {
                return;
            }

            texto = form_pesquisa.texto.ToUpper();
            frmResultado_Load(sender, e);
        }
    }
}
