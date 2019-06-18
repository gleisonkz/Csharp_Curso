using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    //============================================================================================================================
    public class Alunos
    {
        public class Exames
        {
            public string Disciplina { get; set; }
            public int NotaExame { get; set; }
        }

        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public List<Exames> ListaExames { get; set; }
    }

    //============================================================================================================================
    public class Colecoes
    {
        public List<int> ListaNumeros { get; set; }
        public List<string> ListaNomes { get; set; }
        public Dictionary<string, double> DicProdutos { get; set; }
        public List<Alunos> ListaAlunos { get; set; }
        public DataTable DtDados { get; set; }

        //----------------------------------------------
        public Colecoes()
        {
            //------------------------------------------
            #region LISTA_NUMEROS
            ListaNumeros = new List<int>()
            { 14, 16, 8, 13, 3, 15, 9, 12, 45, 34, 23, 56, 32, 11, 43};
            #endregion

            //------------------------------------------
            #region LISTA_NOMES
            ListaNomes = new List<string>()
            { "João Ribeiro", "Carla Marques", "Paulo Silva", "Franciso Matos",
              "Anabela Santos", "Carolina Soares", "Marta Silva", "Ricardo Almeida",
              "Tiago Ribeiro", "Paulo Fonseca"};
            #endregion

            //------------------------------------------
            #region LISTA_PRODUTOS
            DicProdutos = new Dictionary<string, double>()
            {
                { "Laranja", 12.5 },
                { "Maçã", 8.7},
                { "Ananás", 17.2},
                { "Maracujá", 4.6},
                { "Banana", 2.8},
                { "Pão", 1.2},
                { "Sorvete", 8},
                { "Refrigerante", 18.5},
                { "Queijo", 32.2},
                { "Arroz", 12.4}
            };
            #endregion

            //------------------------------------------
            #region LISTA_ALUNOS
            ListaAlunos = new List<Alunos>();
            Alunos aluno;

            //aluno 1
            aluno = new Alunos();
            aluno.Numero = 1;
            aluno.Nome = "Ana Carolina";
            aluno.Sexo = "feminino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 12},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 14},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 9 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 11}
            };
            ListaAlunos.Add(aluno);

            //aluno 2
            aluno = new Alunos();
            aluno.Numero = 2;
            aluno.Nome = "Bernardo José";
            aluno.Sexo = "masculino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 16},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 15},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 17 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 18}
            };
            ListaAlunos.Add(aluno);

            //aluno 3
            aluno = new Alunos();
            aluno.Numero = 3;
            aluno.Nome = "Cristina Marques";
            aluno.Sexo = "feminino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 8},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 11},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 10 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 7}
            };
            ListaAlunos.Add(aluno);

            //aluno 4
            aluno = new Alunos();
            aluno.Numero = 4;
            aluno.Nome = "Fernando Castro";
            aluno.Sexo = "masculino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 13},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 15},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 12 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 13}
            };
            ListaAlunos.Add(aluno);

            //aluno 5
            aluno = new Alunos();
            aluno.Numero = 5;
            aluno.Nome = "Helena Cristina";
            aluno.Sexo = "feminino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 18},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 17},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 18 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 20}
            };
            ListaAlunos.Add(aluno);

            //aluno 6
            aluno = new Alunos();
            aluno.Numero = 6;
            aluno.Nome = "Luis Miguel";
            aluno.Sexo = "masculino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 11},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 12},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 10 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 11}
            };
            ListaAlunos.Add(aluno);

            //aluno 7
            aluno = new Alunos();
            aluno.Numero = 7;
            aluno.Nome = "Márcia Correia";
            aluno.Sexo = "feminino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 16},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 15},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 17 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 12}
            };
            ListaAlunos.Add(aluno);

            //aluno 8
            aluno = new Alunos();
            aluno.Numero = 8;
            aluno.Nome = "Rogério Fernandes";
            aluno.Sexo = "masculino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 8},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 9},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 9 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 7}
            };
            ListaAlunos.Add(aluno);

            //aluno 9
            aluno = new Alunos();
            aluno.Numero = 9;
            aluno.Nome = "Susana Martins";
            aluno.Sexo = "feminino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 13},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 13},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 16 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 14}
            };
            ListaAlunos.Add(aluno);

            //aluno 10
            aluno = new Alunos();
            aluno.Numero = 2;
            aluno.Nome = "Tomé Costa";
            aluno.Sexo = "masculino";
            aluno.ListaExames = new List<Alunos.Exames>()
            {
                new Alunos.Exames() { Disciplina = "Matemática", NotaExame = 18},
                new Alunos.Exames() { Disciplina = "Inglês", NotaExame = 19},
                new Alunos.Exames() { Disciplina = "Biologia", NotaExame = 19 },
                new Alunos.Exames() { Disciplina = "Laboratório", NotaExame = 17}
            };
            ListaAlunos.Add(aluno);
            #endregion

            //------------------------------------------
            #region DATATABLE
            //estrutura da datatable
            DtDados = new DataTable();
            DtDados.Columns.Add("ClienteID", typeof(int));
            DtDados.Columns.Add("NomeCliente", typeof(string));
            DtDados.Columns.Add("Cidade", typeof(string));
            DtDados.Columns.Add("NumeroEncomendas", typeof(int));

            //carrega os dados de todos os clientes
            StreamReader file = new StreamReader(Environment.CurrentDirectory + @"\dados.txt", Encoding.Default);
            while (!file.EndOfStream)
            {
                DataRow linha = DtDados.NewRow();
                linha["ClienteID"] = int.Parse(file.ReadLine());
                linha["NomeCliente"] = file.ReadLine();
                linha["Cidade"] = file.ReadLine();
                linha["NumeroEncomendas"] = int.Parse(file.ReadLine());
                DtDados.Rows.Add(linha);
            }
            file.Dispose();
            #endregion
        }
    }

    //============================================================================================================================

}
