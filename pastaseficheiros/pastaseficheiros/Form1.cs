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

namespace pastaseficheiros
{
    public partial class Form1 : Form
    {
        string pasta_temp = @"C:\Users\Gleison\Documents\Gleison\config";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(pasta_temp))
            {
                MessageBox.Show("A pasta já existe");
                StreamWriter config = new StreamWriter(@"C:\Users\Gleison\Documents\Gleison\config\config.txt");
                config.WriteLine(textBox1.Text);
                config.WriteLine(dateTimePicker1.Text);
                config.Dispose();
            }
            else
            {
                GravarConfiguraçoes();
                MessageBox.Show("A pasta foi criada e as configurações foram gravadas.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\config\config.txt"))
            {
                GravarConfiguraçoes();
                CarregarConfiguraçoes();
            }
            else
            {
                CarregarConfiguraçoes();
            }
        }

        private void GravarConfiguraçoes()
        {
            Directory.CreateDirectory(pasta_temp);
            StreamWriter config = new StreamWriter(@"C:\Users\Gleison\Documents\Gleison\config\config.txt");
            config.WriteLine(textBox1.Text);
            config.WriteLine(dateTimePicker1.Value);
            config.WriteLine(dateTimePicker1.Value);
            config.WriteLine(dateTimePicker1.Value);
            config.WriteLine(dateTimePicker1.Value);
            config.WriteLine(dateTimePicker1.Value);
            config.WriteLine(dateTimePicker1.Value);
            config.Dispose();
        }

        private void CarregarConfiguraçoes()
        {
            StreamReader loadconfig = new StreamReader(@"C:\config\config.txt", Encoding.Default);
            textBox1.Text = loadconfig.ReadLine();
            dateTimePicker1.Value = DateTime.Parse(loadconfig.ReadLine());
            loadconfig.Dispose();
        }
    }
}
