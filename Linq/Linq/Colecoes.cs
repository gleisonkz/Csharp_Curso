using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Linq.Alunos;
using static Linq.Alunos.Exames;

namespace Linq
{
    //============================================================================================================================
    public class Alunos
    {
        public enum eSexo
        {
            Masculino = 1,
            Feminino = 2,
        }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public eSexo Sexo { get; set; }
        public List<Exames> ListaExames { get; set; }

        public class Exames
        {
            public enum eDisciplina
            {
                Matemática = 0,
                Inglês = 1,
                Biologia = 2,
                Laboratório = 3
            }

            public Dictionary<eDisciplina,int> DicExames { get; set; }

            public eDisciplina Disciplina { get; set; }
            public int NotaExame { get; set; }
        }
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
            { "João Ribeiro",
              "Carla Marques",
              "Paulo Silva",
              "Franciso Matos",
              "Anabela Santos",
              "Carolina Soares",
              "Marta Silva",
              "Ricardo Almeida",
              "Tiago Ribeiro",
              "Paulo Fonseca" };
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

            ListaAlunos = new List<Alunos>()
            {   
                    //Aluno 1
                    new Alunos()
                    {
                        Numero = 1,
                        Nome = "Ana Carolina",
                        Sexo = eSexo.Feminino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 12},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 14},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 9 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 11},
                    }},

                    //Aluno 2
                    new Alunos()
                    {
                        Numero = 2,
                        Nome = "Bernardo José",
                        Sexo = eSexo.Masculino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 15},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 17 },
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 16},
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 18}
                    }},                    

                    //Aluno 3
                    new Alunos()
                    {
                        Numero = 3,
                        Nome = "Cristina Marques",
                        Sexo = eSexo.Feminino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 8},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 11},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 10 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 7}
                    }},                   

                    //Aluno 4
                    new Alunos()
                    {
                        Numero = 4,
                        Nome = "Fernando Castro",
                        Sexo = eSexo.Masculino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 13},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 15},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 12 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 13}
                    }},                    

                    //Aluno 5
                    new Alunos()
                    {
                        Numero = 5,
                        Nome = "Helena Cristina",
                        Sexo = eSexo.Feminino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 18},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 17},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 18 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 20}
                    }},                    

                    //Aluno 6
                    new Alunos()
                    {
                        Numero = 6,
                        Nome = "Luis Miguel",
                        Sexo = eSexo.Masculino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 11},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 12},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 10 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 11}
                    }},                    

                    //Aluno 7
                    new Alunos()
                    {
                        Numero = 7,
                        Nome = "Márcia Correia",
                        Sexo = eSexo.Feminino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 16},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 15},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 17 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 12}
                    }},                    

                    //Aluno 8
                    new Alunos()
                    {
                        Numero = 8,
                        Nome = "Rogério Fernandes",
                        Sexo = eSexo.Masculino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 8},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 9},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 9 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 7}
                    }},                    

                    //Aluno 9
                    new Alunos()
                    {
                        Numero = 9,
                        Nome = "Susana Martins",
                        Sexo = eSexo.Feminino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 13},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 13},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 16 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 14}
                    }},                    

                    //Aluno 10
                    new Alunos()
                    {
                        Numero = 10,
                        Nome = "Tomé Costa",
                        Sexo = eSexo.Masculino,
                        ListaExames = new List<Exames>()
                    {
                        new Exames() { Disciplina = eDisciplina.Matemática, NotaExame = 18},
                        new Exames() { Disciplina = eDisciplina.Inglês, NotaExame = 19},
                        new Exames() { Disciplina = eDisciplina.Biologia, NotaExame = 19 },
                        new Exames() { Disciplina = eDisciplina.Laboratório, NotaExame = 17}
                    }}
            };


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
