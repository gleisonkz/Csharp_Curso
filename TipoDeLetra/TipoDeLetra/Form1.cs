using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoDeLetra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Helvetica", 50,FontStyle.Bold | FontStyle.Italic,GraphicsUnit.Pixel);

            label1.Font = letra;

            label1.ForeColor = Color.Red;
        }
    }
}
