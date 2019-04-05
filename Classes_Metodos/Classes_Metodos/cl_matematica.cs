using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Metodos
{
    class cl_matematica  
    {
        double valor1;
        double valor2;

        
        public double Operacoes(double valor1, double valor2, string operacao)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;

            double resultado = 0;


            if (operacao == "adicao")
                resultado = adicao();
            else if (operacao == "subtracao")
                resultado = subtracao();
            else if (operacao == "multiplicacao")
                resultado = multiplicacao();
            else if (operacao == "divisao")
                resultado = divisao();

            return resultado;
        }

        private double adicao()
        {
            return valor1 + valor2;
        }

        private double divisao()
        {
            return valor1 / valor2;
        }

        private double multiplicacao()
        {
            return valor1 * valor2;
        }

        private double subtracao()
        {
            return valor1 - valor2;
        }
                     
    }
}


//switch (operacao) {

//    case "adicao":
//        resultado = valor1 + valor2;
//        break;
//    case "subtracao":
//        resultado = valor1 - valor2;
//        break;
//    case "divisao":
//        resultado = valor1 / valor2;
//        break;
//    case "multiplicacao":
//        resultado = valor1 * valor2;
//        break;
//    default:
//        resultado = -1000;
//        break;
//}

//if (operacao == "adicao")
//    resultado = valor1 + valor2;
//else if (operacao == "subtracao")
//    resultado = valor1 - valor2;
//else if (operacao == "multiplicacao")
//resultado = valor1 * valor2;
//else if (operacao == "divisao")
//resultado = valor1 / valor2;