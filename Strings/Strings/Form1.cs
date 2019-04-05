using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //STRINGS


            string nome = "João Ribeiro";
            string apelido = "Silva ";

            string nome_completo = nome.Insert(5, apelido);
            caixa_texto.Text = nome_completo;

                
  


          

            //string fraseM = frase.Substring(5);
            //bool resultado = frase.Contains("é");

            //caixa_texto.Font = new Font("Helvetica", 18, FontStyle.Regular, GraphicsUnit.Pixel);
            //caixa_texto.Text = fraseM + " ( contém " + frase.Length + " letras)";
            ////caixa_texto.Text = resultado.ToString();
        }
    }
}
