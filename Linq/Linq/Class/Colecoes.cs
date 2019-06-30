using Linq.Enumeradores;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using static Linq.Alunos;

namespace Linq
{
    //============================================================================================================================
    public class Alunos
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public eSexo Sexo { get; set; }
        public List<Exames> ListaExames { get; set; }

        public class Exames
        {
            public Dictionary<eDisciplina, int> DicExames { get; set; }
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
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,12 },
                                {eDisciplina.Inglês,14 },
                                {eDisciplina.Biologia,9 },
                                {eDisciplina.Laboratório,11 }
                            }
                        }
                    }
                },

                //Aluno 2
                new Alunos()
                {
                    Numero = 2,
                    Nome = "Bernardo José",
                    Sexo = eSexo.Masculino,
                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,16 },
                                {eDisciplina.Inglês,15 },
                                {eDisciplina.Biologia,17 },
                                {eDisciplina.Laboratório,18 }
                            }
                        }
                    }
                },                    

                //Aluno 3
                new Alunos()
                {
                    Numero = 3,
                    Nome = "Cristina Marques",
                    Sexo = eSexo.Feminino,
                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,8 },
                                {eDisciplina.Inglês,11 },
                                {eDisciplina.Biologia,10 },
                                {eDisciplina.Laboratório,7 }
                            }
                        }
                    }
                },                   

                //Aluno 4
                new Alunos()
                {
                    Numero = 4,
                    Nome = "Fernando Castro",
                    Sexo = eSexo.Masculino,
                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,13 },
                                {eDisciplina.Inglês,15 },
                                {eDisciplina.Biologia,12 },
                                {eDisciplina.Laboratório,13 }
                            }
                        }
                    }
                },                    

                //Aluno 5
                new Alunos()
                {
                    Numero = 5,
                    Nome = "Helena Cristina",
                    Sexo = eSexo.Feminino,
                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,18 },
                                {eDisciplina.Inglês,17 },
                                {eDisciplina.Biologia,18 },
                                {eDisciplina.Laboratório,20 }
                            }
                        }
                    }
                },                    

                //Aluno 6
                new Alunos()
                {
                    Numero = 6,
                    Nome = "Luis Miguel",
                    Sexo = eSexo.Masculino,
                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,11 },
                                {eDisciplina.Inglês,12 },
                                {eDisciplina.Biologia,10 },
                                {eDisciplina.Laboratório,11 }
                            }
                        }
                    }
                },                    

                //Aluno 7
                new Alunos()
                {
                    Numero = 7,
                    Nome = "Márcia Correia",
                    Sexo = eSexo.Feminino,

                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,16 },
                                {eDisciplina.Inglês,15 },
                                {eDisciplina.Biologia,17 },
                                {eDisciplina.Laboratório,12 }
                            }
                        }
                    }
                },                    

                //Aluno 8
                new Alunos()
                {
                    Numero = 8,
                    Nome = "Rogério Fernandes",
                    Sexo = eSexo.Masculino,

                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,8 },
                                {eDisciplina.Inglês,9 },
                                {eDisciplina.Biologia,9 },
                                {eDisciplina.Laboratório,7 }
                            }
                        }
                    }
                },                    

                //Aluno 9
                new Alunos()
                {
                    Numero = 9,
                    Nome = "Susana Martins",
                    Sexo = eSexo.Feminino,

                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,13 },
                                {eDisciplina.Inglês,13 },
                                {eDisciplina.Biologia,16 },
                                {eDisciplina.Laboratório,14 }
                            }
                        }
                    }
                },                    

                //Aluno 10
                new Alunos()
                {
                    Numero = 10,
                    Nome = "Tomé Costa",
                    Sexo = eSexo.Masculino,

                    ListaExames = new List<Exames>()
                    {
                        new Exames()
                        {
                            DicExames = new Dictionary<eDisciplina, int>()
                            {
                                {eDisciplina.Matemática,18 },
                                {eDisciplina.Inglês,19 },
                                {eDisciplina.Biologia,19 },
                                {eDisciplina.Laboratório,17 }
                            }
                        }
                    }
                }
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
