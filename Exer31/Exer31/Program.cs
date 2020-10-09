using System;

namespace Exer31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 1 ao 10.");

            for (int numero = 1; numero <= 10; numero++)
            {
                for (int expoente = 1; expoente <= 10; expoente++)
                {
                    Console.WriteLine("{0} X {1} = {2}", numero, expoente, numero * expoente);
                }
            }
        }
    }
}
