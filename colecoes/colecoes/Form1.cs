using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Array
            string[] nomes = new string[5];

            nomes[0] = "João";
            nomes[1] = "Antonio";
            nomes[2] = "Carlos";
            nomes[3] = "Rui";
            nomes[4] = "Nuno";

            // Coleção do tipo - LIST

            List<string> NOMES = new List<string>();

            NOMES.Add("João");
            NOMES.Add("Antonio");
            NOMES.Add("Carlos");
            NOMES.Add("Rui");
            NOMES.Add("João");
            NOMES.Remove("Rui");
            //foreach (string item in NOMES)
            //{
            //    lista.Items.Add(item);
            //}

            //MessageBox.Show(NOMES.Count.ToString());

        
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> listaInteiros = new List<int>() { 10, 20, 30 };

            foreach (int valor in listaInteiros)
            {
                lista.Items.Add(valor);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> listaDuplicados = new List<string>();
            HashSet<string> listaNomes = new HashSet<string>()
            {
                "João", "Carlos", "Rui", "Marco"
            };

            if (listaNomes.Add("João") == false)
            {
                listaDuplicados.Add("João");
            }
            

            MessageBox.Show(listaNomes.Count.ToString());
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> lista_valores = new Dictionary<string, string>();
            
            lista_valores.Add("button4", "Dictionary");
            lista_valores.Add("button3", "HashSet");
            lista_valores.Add("button2", "List Inline");

            foreach (KeyValuePair <string,string> item in lista_valores)
            {
                lista.Items.Add(item.Value);
            }

            if (lista_valores.ContainsKey("button5"))
            {
                MessageBox.Show("SIM");
            }
            else
            {
                MessageBox.Show("NÂO");
            }
        }
    }
}
