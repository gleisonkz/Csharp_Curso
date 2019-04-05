using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArquivosDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // gravar arquivo de texto
            StreamWriter arquivo = new StreamWriter(@"C:\Users\Gleison\Documents\Gleison\file.txt",true,Encoding.Default);
            arquivo.WriteLine(textBox1.Text);
            arquivo.Dispose();
            MessageBox.Show("Mensagem Inserida");
            textBox1.Text = string.Empty;
            ActiveControl = textBox1; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader arquivo = new StreamReader(@"C:\Users\Gleison\Documents\Gleison\file.txt",Encoding.Default);
            List<string> lista_T = new List<string>();

            while (!arquivo.EndOfStream)
            {
                lista_T.Add(arquivo.ReadLine());
            }

            arquivo.Dispose();
        }
    }
}
