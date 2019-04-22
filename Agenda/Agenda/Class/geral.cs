using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Agenda
{
    public static class Geral
    {
        public static string versao = "v1.0.0";

        public static string nome_arquivo_base_de_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BASE_DE_DADOS.TXT";

        public static List<Contato> listaDeContatos;

        //===========================================================================================

        public static void AtualizaListaDeContatos() //Método para carregar a lista de contatos do TXT.
        {
            listaDeContatos = new List<Contato>(); // Instanciação da lista de contatos.

            if (File.Exists(nome_arquivo_base_de_dados)) //Verifica se o arquivo existe.
            {  
                //Instanciação do leitor de arquivos.
                StreamReader arquivo = new StreamReader(nome_arquivo_base_de_dados, Encoding.Default);
                
                while (!arquivo.EndOfStream) //Executa o comando abaixo até o final do arquivo.
                {

                    //Retorna um array de 02 elementos o '\t' se refere a tabulação.
                    var nomeNumero = arquivo.ReadLine().Split('\t'); 

                    //Atribui o primeiro elemento do array a variavél nome.
                    string nome = nomeNumero[0];

                    //Atribui o segundo elemento do array a variavél número.
                    string numero = nomeNumero[1];

                    //Adiociona a lista de contatos o contato carregado.

                    var novoContato = new Contato();
                    novoContato.nome = nome;
                    novoContato.numero = numero;
                    listaDeContatos.Add(novoContato);
                }
                arquivo.Dispose();
            }
        }

        //===========================================================================================

        public static bool VerificaDulicidadeContato(string nome, string numero)
        {
            bool contatoDuplicado = false;

            foreach (Contato item in listaDeContatos)
            {
                if (item.nome == nome && item.numero == numero)
                {
                    contatoDuplicado = true;
                    break;
                }
            }
            return contatoDuplicado;
        }

        //===========================================================================================

        public static void AtualizaArquivoBancoDeDados()
        {
            //Instanciação do gravador de arquivos.
            StreamWriter SW = new StreamWriter(nome_arquivo_base_de_dados, false, Encoding.Default);

            foreach (Contato item in listaDeContatos)
            {
                SW.WriteLine($"{item.nome}\t{item.numero}");
            }
            SW.Dispose();
        }

        //===========================================================================================

        public static void InserirContatoLista(string nome, string numero)
        {
            //Adiciona um novo registro na lista e na base de dados

            listaDeContatos.Add(new Contato() { nome = nome, numero = numero });
            AtualizaArquivoBancoDeDados();
        }

        //===========================================================================================

        public static void InserirContatoLista(string nome, string numero, int index)
        {
            //Atualiza o registro na lista e na base de dados

            var contato = new Contato() { nome = nome, numero = numero };

            listaDeContatos[index].nome = nome;
            listaDeContatos[index].numero = numero;
        }

        //===========================================================================================

        public static void ApagaContadoLista(int index)
        {
            //Remove o registro da lista e da base de dados

            listaDeContatos.RemoveAt(index);
            AtualizaArquivoBancoDeDados();
        }

        public static Contato BuscarContatoLista(int index)
        {
            var contato = listaDeContatos[index];
            return contato;
        }

    }
}
