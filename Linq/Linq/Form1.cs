using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class Form1 : Form
    {
        enum eTipoConta
        {
            Poupança = 1,
            Salario = 2,
            Corrente = 3,
        }

        class Conta
        {



            public string Titular { get; set; }
            public int Numero { get; set; }
            public Enum TipoConta { get; set; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            #region Lista
            List<string> listaNomes = new List<string>
            {
                "João",
                "Carlos",
                "Renato",
                "Demagister",
                "Paula",
                "Roberta",
                "Camila",
                "Rogerio",
                "Carlinhos",
                "Jesus",
                "Rogerio",
                "Marta",
                "Ricardinho",
                "Alberto"
            };
            #endregion

            List<string> final = listaNomes.Where(c => c.StartsWith("A")).ToList();
            listBox1.Items.Add(final[0]);

            ////var final = from c in listaNomes
            //            where c.StartsWith("A")
            //            select c;



            #region TesteConta
            List<Conta> listAccount = new List<Conta>
            {
               new Conta{
                   Titular = "Carls",
                   Numero = 17538049,
                   TipoConta = eTipoConta.Corrente
               },
               new Conta{
                   Titular = "Pawl",
                   Numero = 75839203,
                   TipoConta = eTipoConta.Poupança
               },
               new Conta{
                   Titular = "Steph",
                   Numero = 01929384,
                   TipoConta = eTipoConta.Salario
               },
               new Conta{
                   Titular = "May",
                   Numero = 47583920,
                   TipoConta = eTipoConta.Corrente
               }
            };

            var resultado = from c in listAccount
                            where c.TipoConta.Equals(eTipoConta.Corrente)
                            select new { c.Titular, c.TipoConta };

            var result = listAccount.Where(c => c.TipoConta.Equals(eTipoConta.Corrente))
                                            .Select(c => new { c.Titular, c.TipoConta })
                                            .ToList(); 
            #endregion



            //foreach (var item in final)
            //{
            //    listBox1.Items.Add(item);
            //}


        }
    }
}
