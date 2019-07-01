using Linq.Class;
using Linq.Enumeradores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Linq.Alunos;
using static Linq.Alunos.Exames;

namespace Linq
{
    public partial class Form1 : Form
    {
        private readonly List<int> listaNumeros;
        private readonly List<string> listaNomes;
        private Dictionary<string, double> dicProdutos;
        private readonly List<Alunos> listaAlunos;
        private readonly DataTable dtDados;

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

            ////Selecionando na lista de numeros os menores ou igual a 10 e multiplicando por 10.

            //listaNumeros.Where(b => b <= 10)
            //            .Select(c => c * 10)
            //            .ToList()
            //            .ForEach(d => listBox1.Items.Add(d));

            ////Inserindo na listbox o nome e nº dos alunos.

            //listaAlunos.ForEach(d => listBox1.Items.Add($"O aluno nº {d.Numero} é {d.Nome}"));

            ////Selecionando na lista de alunos os que contém a letra a e projetando o objeto com uma nova estrutura e inserindo na listbox.

            //listaAlunos.Where(b => b.Nome.Contains("a"))
            //           .Select(c => new
            //           {
            //               nomeAluno = c.Nome,
            //               numeroAluno = c.Numero,
            //               sexoAluno = c.Sexo
            //           })
            //           .ToList()
            //           .ForEach(d => listBox1.Items.Add(d.nomeAluno));



            ////Utilizando uma lista de índices para realizar a seleção dos nomes na lista.

            //int[] indices = new int[] { 3, 2, 1 };
            //var index = 1;

            //indices.Select(c => listaNomes[c])
            //       .ToList()
            //       .ForEach(d => listBox1.Items.Add($"Lista de índices {index++} {d}"));

            ////Selecionando todas as notas dos exames de Biologia e adicionando ao Grid.

            //listaAlunos.SelectMany(a => a.ListaExames)                       
            //           .ToList()
            //           .ForEach(c=> listBox1.Items.Add(c.DicExames[eDisciplina.Biologia]));

            #endregion

            #region Operador de Ordenaçao - ORDER BY

            //listaNumeros.OrderBy(c => c)
            //            .ToList()
            //            .ForEach(d => listBox1.Items.Add(d));

            //listaAlunos.OrderByDescending(c => c.Nome.Length)
            //           .ToList()
            //           .ForEach(d => listBox1.Items.Add($"{d.Nome} ({d.Nome.Length})"));

            //dicProdutos.OrderByDescending(a => a.Key)
            //           .ToList()
            //           .ForEach(b => listBox1.Items.Add(b.Value));


            #endregion

            #region Operadores de Agregação COUNT - SUM - AVERAGE - MAX E MIN

            //// COUNT

            //listBox1.Items.Add($"Total Count = {listaNumeros.Count}");
            //listBox1.Items.Add($"Count Numbers < 20 = {listaNumeros.Count(c => c < 20)}");

            //// MAX E MIN

            //listBox1.Items.Add($"The smallest even number is {listaNumeros.Where(a=> a%2 == 0).ToList().Min()}");
            //listBox1.Items.Add($"The biggest odd number is {listaNumeros.Where(a=> a%2 == 1).ToList().Max()}");

            //listaAlunos.Where(c=>c.Nome.Length == listaAlunos.Max(d=> d.Nome.Length))
            //           .ToList().ForEach(a=> listBox1.Items.Add($"O aluno com o maior nome é: {a.Nome}"));

            //// AVERAGE


            //listBox1.Items.Add($"The average of numbers is {decimal.Round(Convert.ToDecimal((listaNumeros.Average())),2)}");
            //listBox1.Items.Add($"The average of numbers is {listaNumeros.Average()}");

            //// SUM

            //label1.Text = listaNumeros.Where(a => a < 20)
            //                          .ToList()
            //                          .Sum()
            //                          .ToString();

            //listaNumeros.Where(a => a < 20)
            //            .ToList()
            //            .ForEach(b => listBox1.Items.Add(b));


            #endregion

            #region Operadores de Elementos - FIRST / ELEMENT AT / LAST

            //listBox1.Items.Add($"O terceiro resultado que corresponde a pesquisa é: {listaNomes.Where(a => a.Contains("a")).ElementAtOrDefault(2)}");
            //listBox1.Items.Add($"O primeiro nome da lista é: {listaNomes.First()}");
            //listBox1.Items.Add($"O ultimo nome da lista é: {listaNomes.Last()}");

            #endregion

            #region Exemplos Praticos Parte 1

            ////ALUNOS DO SEXO FEMININO

            //listBox1.Items.Add($"Esta turma tem {listaAlunos.Where(a => a.Sexo == eSexo.Feminino).Count()} alunas.");

            ////NOTAS DO EXAME DE MATEMATICA

            //listaAlunos.SelectMany(a => a.ListaExames).ToList().ForEach(b => listBox1.Items.Add(b.DicExames[eDisciplina.Matemática]));

            //listBox1.Items.Add($@"A soma das notas do exames de Matemática é: {listaAlunos.SelectMany(a => a.ListaExames)
            //                                                                              .Sum(b => b.DicExames[eDisciplina.Matemática])}");

            ////QUANTOS ALUNOS FICARAM NA MÉDIA EM MATEMÁTICA

            //label1.Text = listaAlunos.SelectMany(a => a.ListaExames)
            //                         .Where(b => b.DicExames[eDisciplina.Matemática] >= 11)
            //                         .ToList()
            //                         .Count()
            //                         .ToString();

            //listaAlunos.Where(a => a.ListaExames
            //                                   .Any(b => b.DicExames[eDisciplina.Matemática] >= 11))
            //                      .Select(c => $"{c.Numero} {c.Nome}")
            //                      .ToList()
            //                      .ForEach(d => listBox1.Items.Add(d));

            #endregion

            #region Exemplo Praticos Parte 2

            ////MÉDIA DOS EXAMES DE MATEMÁTICA

            //listBox1.Items.Add($@"A média da turma em Matemática é : {listaAlunos.SelectMany(a => a.ListaExames)
            //                                                                     .Average(b => b.DicExames[eDisciplina.Matemática])}");

            ////MÉDIA E TOTAL DOS EXAMES DE BIOLOGIA

            //listBox1.Items.Add($@"A soma das notas de Biologia é: {listaAlunos.SelectMany(a => a.ListaExames)
            //                                                                  .Sum(b => b.DicExames[eDisciplina.Biologia])}");

            //listBox1.Items.Add($@"A soma das notas de Biologia acima da média é: {listaAlunos.SelectMany(a => a.ListaExames)
            //                                                                                 .Where(b => b.DicExames[eDisciplina.Biologia] >= 10)
            //                                                                                 .Sum(c => c.DicExames[eDisciplina.Biologia])}");

            //listBox1.Items.Add("A média das notas positivas de Biologia é :" + listaAlunos.SelectMany(a => a.ListaExames)
            //                                                                              .Where(b => b.DicExames[eDisciplina.Biologia] >= 10)
            //                                                                              .Average(c => c.DicExames[eDisciplina.Biologia]));

            #endregion

            #region Exemplos Praticos Parte 3

            //MÉDIA GERAL ENTRE OS EXAMES

            //listaAlunos.Select(b => new
            //                        {
            //                          nome = b.Nome,
            //                          media = b.ListaExames
            //                                   .Sum(
            //                                           (c => c.DicExames[eDisciplina.Biologia] +
            //                                            c.DicExames[eDisciplina.Inglês] +
            //                                            c.DicExames[eDisciplina.Laboratório] +
            //                                            c.DicExames[eDisciplina.Matemática])
            //                                           ) / b.ListaExames[0].DicExames.Count
            //                        }
            //                  ).ToList()
            //                   .ForEach( d=> listBox1.Items.Add($@"{d.nome} média geral: {d.media}"));


            // SOMA TOTAL DAS NOTAS DE MATEMATICA

            listaAlunos.Select(b => new
            {
                nome = b.Nome,
                notaMatematica = b.ListaExames
                                   .Sum(
                                           c => c.DicExames[eDisciplina.Matemática]
                                       )
            }
                  ).ToList().OrderByDescending(n => n.notaMatematica).ToList()
                   .ForEach(d => listBox1.Items.Add( $@"{d.nome.PadRight(50,' ')} : {d.notaMatematica}"));

            


            //var melhorAluno = listaAlunos.SelectMany(a => a.ListaExames).Sum(b => b.DicExames[eDisciplina.Biologia]);

            //// SOMA DE TODAS A NOTAS

            //listaAlunos.Select(b => new
            //{
            //    nome = b.Nome,
            //    media = b.ListaExames
            //                                   .Sum(
            //                                           (c => c.DicExames[eDisciplina.Biologia] +
            //                                            c.DicExames[eDisciplina.Inglês] +
            //                                            c.DicExames[eDisciplina.Laboratório] +
            //                                            c.DicExames[eDisciplina.Matemática])
            //                                           )
            //}
            //                  ).OrderByDescending(o => o.media).ToList()
            //                   .ForEach(d => listBox1.Items.Add($@"{d.nome} : {d.media}"));


            //var melhorAluno = listaAlunos.Select(a => new
            //                                             {
            //                                                nome = a.Nome,
            //                                                notaTotal = a.ListaExames.Sum(
            //                                                                                c => c.DicExames[eDisciplina.Biologia] +
            //                                                                                c.DicExames[eDisciplina.Inglês] +
            //                                                                                c.DicExames[eDisciplina.Laboratório] +
            //                                                                                c.DicExames[eDisciplina.Matemática]
            //                                                                             )

            //                                             }
            //                                    ).OrderByDescending(b=> b.notaTotal).First();



            //var teste = listaAlunos.Select(a => new
            //{
            //    nome = a.Nome,
            //    totalNotas = a.ListaExames.Select(b => b.DicExames.Sum(c => c.Value)).Single()
            //}
            //).ToList().OrderByDescending(d=> d.totalNotas);

            //foreach (var aluno in teste)
            //{
            //    listBox1.Items.Add($@"{aluno.nome} {aluno.totalNotas}");
            //}


            return;

            #endregion


         
            #region TesteConta

            //List<Conta> listAccount = new List<Conta>
            //{
            //   new Conta{
            //       Titular = "Carls",
            //       Numero = 17538049,
            //       TipoConta = eTipoConta.Corrente
            //   },
            //   new Conta{
            //       Titular = "Pawl",
            //       Numero = 75839203,
            //       TipoConta = eTipoConta.Poupança
            //   },
            //   new Conta{
            //       Titular = "Steph",
            //       Numero = 01929384,
            //       TipoConta = eTipoConta.Salario
            //   },
            //   new Conta{
            //       Titular = "May",
            //       Numero = 47583920,
            //       TipoConta = eTipoConta.Corrente
            //   }
            //};

            //var projecaoContas = listAccount.Where(c => c.TipoConta == eTipoConta.Corrente)
            //                                .Select(c => new { c.Titular, c.TipoConta })
            //                                    .ToList();
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
