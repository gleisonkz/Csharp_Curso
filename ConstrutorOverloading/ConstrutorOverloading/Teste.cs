using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorOverloading
{
    class teste
    {

        private string _nome;
        private int _idade;

        //Construtor

        public teste(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }


        //=======================================================================
        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(_nome + " > " + _idade);    
        }
        //=======================================================================
        public void Apresentar(string separador)
        {
            System.Windows.Forms.MessageBox.Show(_nome + separador + _idade);
        }
        //=======================================================================
        public void Apresentar(string separador, int idade)
        {
            
        }
    }
}
