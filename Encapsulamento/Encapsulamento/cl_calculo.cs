using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class cl_calculo
    {
        private int percentagem1 = 5;
        private int percentagem2 = 12;
        private int percentagem3 = 23;

        public int CalcularPrecoFinal(int preco_inicial, int tipo_produto)
        {
            int preco_final = 0;

            //calculo do preço final

            switch (tipo_produto)
            {
                //Alimento
                case 1:
                    preco_final = preco_inicial + (preco_inicial * percentagem1 / 100);
                    break;
                //Ferramenta
                case 2:
                    preco_final = preco_inicial + (preco_inicial * percentagem2 / 100);
                    break;
                //Cosmetico
                case 3:
                    preco_final = preco_inicial + (preco_inicial * percentagem3 / 100);
                    break;
            }

            return preco_final;
        }




    }
}
