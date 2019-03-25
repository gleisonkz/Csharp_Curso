using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datahora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(tb_dia.Text);
            int mes = int.Parse(tb_mes.Text);
            int ano = int.Parse(tb_ano.Text);

            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            DateTime nascimento = new DateTime(ano,mes,dia);
            label_resultado.Text = dtfi.GetDayName(nascimento.DayOfWeek);
        }




    }
}
