using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixasdialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------------------------------------------

            //MessageBox - Informação Simples

            //MessageBox.Show("De Bola");

            //-----------------------------------------------------------------------------------

            //MessageBox - Titulo - Botoões - Ícone

            //MessageBox.Show("Mensagem a ser exibida",
            //                "Titulo da TBox",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Information);

            //-----------------------------------------------------------------------------------

            //MessageBox - Caixa de Dialogo com Resultado
            DialogResult = (MessageBox.Show("Deseja sair da aplicação ?",
                            "SAIR",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question));

            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Title = "Escolha o Arquivo";
            abrirArquivo.InitialDirectory = @"C:\";
            abrirArquivo.Filter = "Todos os Arquivos (*.*)|*.*| Arquivos de Texto (*.txt) | *.txt";


            if (abrirArquivo.ShowDialog() == DialogResult.Cancel) return;

            MessageBox.Show("O Usuario escolheu o arquivo " + abrirArquivo.FileName);
            pictureBox1.BackgroundImage = Image.FromFile(abrirArquivo.FileName);
            abrirArquivo.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarArquivo = new SaveFileDialog();
            salvarArquivo.Title = "Salvar Arquivo";
            salvarArquivo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            salvarArquivo.Filter = "Arquivos de Texto (*.txt) | *.txt";
            if (salvarArquivo.ShowDialog() == DialogResult.Cancel) return;

            //Grava o arquivo

            string arquivo = $"{salvarArquivo.FileName}.txt";
            StreamWriter gravar = new StreamWriter(arquivo);
            gravar.WriteLine("TESTE");
            gravar.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog escolherPasta = new FolderBrowserDialog();
            escolherPasta.ShowDialog();
            if (escolherPasta.ShowDialog() == DialogResult.Cancel) return;
            var caminho = escolherPasta.SelectedPath;
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();
            cor.Color = pictureBox1.BackColor;
            if (cor.ShowDialog() == DialogResult.Cancel) return;
            var corEscolhida =cor.Color;
            pictureBox1.BackColor = corEscolhida;
            
            
        }
    }
}
