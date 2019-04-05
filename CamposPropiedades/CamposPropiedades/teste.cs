using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposPropiedades
{
    class teste
    {
        //definição de um CAMPO
        private string _nome;
        private int _idade;



        //definição de uma PROPRIEDADE
        public string Nome { get; set; }

        //public string Nome
        //{
        //    set { _nome = value; }

        //    get{ return _nome; }

        //}




        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(Nome);
        }
    }
}
