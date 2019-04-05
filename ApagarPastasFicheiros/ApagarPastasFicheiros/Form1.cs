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

namespace ApagarPastasFicheiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caminho = @"C:\teste";
            //string destino = @"C:\Users\Gleison\Documents\Gleison\temp\";

            string[] arquivos = Directory.GetFiles(caminho, "*.txt");
            string[] pastas = Directory.GetDirectories(caminho);

            //foreach (var item in arquivos)
            //{
            //    File.Move(item, destino + Path.GetFileName(item));
            //}

            //MessageBox.Show("O arquivo foi movido!");


            foreach (var item in pastas)
            {
                var arq = new FileInfo(item);

                if (arq.Name.Contains("temp"))
                {
                    Directory.Delete(item, true);
                }


            }





        }
    }
}
