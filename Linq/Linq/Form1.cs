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
        private readonly List<int> listaNumeros;
        private readonly List<string> listaNomes;
        private Dictionary<string, double> dicProdutos;
        private readonly List<Alunos> listaAlunos;
        private readonly DataTable dtDados;

        public class Conta
        {
            public enum eTipoConta
            {
                Poupança = 1,
                Salario = 2,
                Corrente = 3,
            }


            public string Titular { get; set; }
            public int Numero { get; set; }
            public Enum TipoConta { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            Colecoes colecoes = new Colecoes();
            this.listaNumeros = colecoes.ListaNumeros;
            this.listaNomes = colecoes.ListaNomes;
            this.dicProdutos = colecoes.DicProdutos;
            this.listaAlunos = colecoes.ListaAlunos;
            this.dtDados = colecoes.DtDados;

        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "";

            #region Operador de Restrição - WHERE
            //listaNumeros.Where(c => c > 20)
            //            .ToList()
            //            .ForEach(d => listBox1.Items.Add(d));

            //listaNomes.Where(c => c.ToLower().Contains("ribeiro") || c.ToLower().Contains("santos"))
            //                .ToList()
            //                .ForEach(d => listBox1.Items.Add(d));

            //dicProdutos.Where(c => c.Key.StartsWith("M"))
            //           .ToList()
            //           .ForEach(d => listBox1.Items.Add($"{d.Key} - {d.Value}")); 
            #endregion

            #region Operador de Projeção - SELECT

            //listaNumeros.Where(b => b <= 10)
            //            .Select(c => c * 10)
            //            .ToList()
            //            .ForEach(d => listBox1.Items.Add(d));

            //listaAlunos.ForEach(d => listBox1.Items.Add($"O aluno nº {d.Numero} é {d.Nome}"));

            //listaAlunos.Where(b => b.Nome.Contains("a"))
            //           .Select(c => new
            //           {
            //               nomeAluno = c.Nome,
            //               numeroAluno = c.Numero,
            //               sexoAluno = c.Sexo
            //           })
            //           .ToList()
            //           .ForEach(d => listBox1.Items.Add(d.nomeAluno));

            //int[] indices = new int[] { 3, 2, 1 };

            //indices.Select(c => listaNomes[c])
            //       .ToList()
            //       .ForEach(d => listBox1.Items.Add(d));

            //listaNomes.ForEach(c => listBox1.Items.Add(c));

            #endregion

            #region Operador de Ordenaçao - ORDER BY

            //listaNumeros.OrderBy(c => c)
            //            .ToList()
            //            .ForEach(d => listBox1.Items.Add(d));

            //listaAlunos.OrderByDescending(c => c.Nome.Length)
            //           .ToList()
            //           .ForEach(d => listBox1.Items.Add($"{d.Nome} ({d.Nome.Length})"));
            FCM - 16 / 05 / 2019 - 19:12
            //dicProdutos.OrderByDescending(a => a.Key)
            //           .ToList()
            //           .ForEach(b => listBox1.Items.Add(b.Value));


            #endregion






            return;

            #region TesteConta
            //List<Conta> listAccount = new List<Conta>
            //{
            //   new Conta{
            //       Titular = "Carls",
            //       Numero = 17538049,
            //       TipoConta = Conta.eTipoConta.Corrente
            //   },
            //   new Conta{
            //       Titular = "Pawl",
            //       Numero = 75839203,
            //       TipoConta = Conta.eTipoConta.Poupança
            //   },
            //   new Conta{
            //       Titular = "Steph",
            //       Numero = 01929384,
            //       TipoConta = Conta.eTipoConta.Salario
            //   },
            //   new Conta{
            //       Titular = "May",
            //       Numero = 47583920,
            //       TipoConta = Conta.eTipoConta.Corrente
            //   }
            //};

            //var resultado = from c in listAccount
            //                where c.TipoConta.Equals(Conta.eTipoConta.Corrente)
            //                select new { c.Titular, c.TipoConta };

            //var result = listAccount.Where(c => c.TipoConta.Equals(Conta.eTipoConta.Corrente))
            //                                .Select(c => new { c.Titular, c.TipoConta })
            //                                .ToList();
            #endregion

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add($"ListaNumeros = {listaNumeros.Count} ");
            listBox1.Items.Add($"ListaNomes = {listaNomes.Count} ");
            listBox1.Items.Add($"ListaProdutos = {dicProdutos.Count} ");
            listBox1.Items.Add($"ListaAlunos = {listaAlunos.Count} ");
            listBox1.Items.Add($"DataTable dados = {dtDados.Rows.Count} linhas ");
        }
    }
}
