using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cores
{
    public partial class Form1 : Form
    {
        Color cor = Color.FromArgb(0,0,0);


        //--------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            ApresentarCor();
        }


        //--------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            caixa.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);

        }


        //--------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            ApresentarCor();
        }


        //--------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------
        private void ApresentarCor()
        {
            cor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            label1.Text = trackBar1.Value.ToString();
            label2.Text = trackBar2.Value.ToString();
            label3.Text = trackBar3.Value.ToString();
            caixa.BackColor = cor;
            label_exemplo.Text = "RGB: " + $"{trackBar1.Value} {trackBar2.Value} {trackBar3.Value}";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ApresentarCor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ApresentarCor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
           ApresentarCor();
        }
    }
}
