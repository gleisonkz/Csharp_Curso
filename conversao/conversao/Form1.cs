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

namespace conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo = new StreamWriter(@"C:\Users\Gleison\Documents\Gleison\dados.txt", true, Encoding.Default);
            //String
            arquivo.WriteLine("Esta frase é alfanumeréica.");

            //Inteiro
            int valor = 150;
            arquivo.WriteLine(valor);

            //Boleano

            bool resultado = false;
            arquivo.WriteLine(resultado);

            //Data
            arquivo.WriteLine(DateTime.Now);

            //Cor
            Color cor = Color.FromArgb(30, 125, 232);
            arquivo.WriteLine(cor.ToArgb());

            arquivo.Dispose();
            Application.Exit();
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            StreamReader arquivo = new StreamReader(@"C:\Users\Gleison\Documents\Gleison\dados.txt",Encoding.Default);

            string a = arquivo.ReadLine();
            int b = int.Parse(arquivo.ReadLine());
            bool c = bool.Parse(arquivo.ReadLine());
            DateTime d = DateTime.Parse(arquivo.ReadLine());
            Color cor = Color.FromArgb(int.Parse(arquivo.ReadLine()));
            pictureBox1.BackColor = cor;
            

            MessageBox.Show(d.Year.ToString() + c.ToString() + b.ToString() + a);





            arquivo.Dispose();

        }
    }
}
