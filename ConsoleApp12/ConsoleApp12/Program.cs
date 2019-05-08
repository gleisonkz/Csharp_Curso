using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] {

                "Carlos",
                "João",
                "Paula",
                "Frederico",
                "Ricardo",
            };

            foreach (var item in nomes)
            {
                Console.Write($"{item}\t");                
            } 

            Console.WriteLine();

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"{nomes[i]}\t");
            }

            Console.ReadKey();
        }
    }
}
