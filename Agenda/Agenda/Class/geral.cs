using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public static class geral
    {
        public static string versao = "v1.0.0";

        //Lista que irá receber as informações da agenda

        public static List<contato> listaDeContatos;

        public static void CriarListaContatos() //Metodo para carregar a lista de contatos
        {
            listaDeContatos = new List<contato>(); // Instancia a lista de contatos

            string meus_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_base_de_dados = meus_documentos + @"\BASE_DE_DADOS.TXT";

            if (File.Exists(nome_base_de_dados)) //Verifica se o arquivo existe
            {  
                StreamReader str = new StreamReader(nome_base_de_dados, Encoding.Default);

                //Carregar todos os contatos do arquivo
                
                while (!str.EndOfStream)
                {
                    //Carrega o nome
                    string nome = str.ReadLine();
                    //Carrega o numero
                    string numero = str.ReadLine();

                    //Adiocionar a lista de contatos o contato carregado

                    contato novoContato = new contato();
                    novoContato.nome = nome;
                    novoContato.numero = numero;
                    listaDeContatos.Add(novoContato);
                }

  

                str.Dispose();
            }
        }
    }
}
