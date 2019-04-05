using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class pessoa
    {

        public string nome;
        public string apelido;

        public void IdentificarSe()
        {
            System.Windows.Forms.MessageBox.Show("Olá, o meu nome é " + JuntarNome());
        }


        private string JuntarNome()
        {
            return nome + " " + apelido;
        }





    }
}
