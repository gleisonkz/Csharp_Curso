using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var lista1 = new List<string>();
            //lista1.Add("Marcos");
            //lista1.Add("Henrique");
            //lista1.Add("Joaquim");
            //lista1.Add("Felipe");
            //lista1.Add("Ronaldo");
            //lista1.Add("Pedro");

            //var lista2 = new List<string>();

            //lista2.Add("Carlos");
            //lista2.Add("Paula");
            //lista2.Add("Joaquim");
            //lista2.Add("Felipe");
            //lista2.Add("Rita");
            //lista2.Add("Ricardo");


            var registrosDuplicados = new List<string>();
            var exclusivosLista1 = new List<string>();
            var exclusivosLista2 = new List<string>();

            var lista1 = new List<string>();
            var lista2 = new List<string>();
            string selectedFolder = null;

            //var fbd = new FolderBrowserDialog();
            //fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //var tela = fbd.ShowDialog();

            var ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            ofd.DefaultExt = "*.txt";
            var arquivo = ofd.ShowDialog();

            if (arquivo != DialogResult.OK)
            {
                return;
            }

            selectedFolder = ofd.FileName;

            var sr = new StreamReader(selectedFolder, Encoding.Default);

            while (!sr.EndOfStream)
            {
                var item = sr.ReadLine().Split('\t');
                lista1.Add(item[0]);
                lista2.Add(item[1]);
            }
            sr.Dispose();


            foreach (var item1 in lista1)
            {
                bool encontrou = false;

                foreach (var item2 in lista2)
                {
                    if (item1 == item2)
                    {
                        registrosDuplicados.Add(item1);
                        encontrou = true;
                        break;
                    }
                    else
                    {
                        encontrou = false;
                    }
                }

                if (encontrou == false)
                {
                    exclusivosLista1.Add(item1);
                }
            }

            foreach (var item2 in lista2)
            {
                bool encontrou = false;

                foreach (var item1 in lista1)
                {
                    if (item1 == item2)
                    {
                        encontrou = true;
                        break;
                    }
                    else
                    {
                        encontrou = false;
                    }
                }

                if (encontrou == false)
                {
                    exclusivosLista2.Add(item2);
                }
            }



        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //VARIAVEIS NUMERICAS

            ////byte = 1 byte = 0 a 255
            //byte idade = 45; 

            //// short = 2 bytes = -32.768 to 32.767
            //short idade2 = 45;

            //// int = 4 bytes = -2.147.483.648 to 2.147.483.647
            //int idade_planeta = 234982347;

            //// long = = 8 bytes -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            //long valor_enorme = 3245683746354;

            //// COM CASAS DECIMAIS

            //float valor1 = 1.5f;
            //double valor2 = 1.5d;
            //decimal valor3 = 1.5m;

            //ALFANUMERICAS

            //string resultado = "João Ribeiro";
            //char caracter1 = 'a';
            //bool decisao = false;




            //caixa_texto.Text = resultado;


        }


    }
}

