using System;

namespace Exer30
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero = 0;

            while (numero <= 4)
            {
                Console.WriteLine("Digite um valor inteiro, positivo e maior que 4");
                numero = decimal.Parse(Console.ReadLine());
                if (numero <= 4)
                    Console.WriteLine("Numéro não contempla os requisitos");
            }

            Console.WriteLine("S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/{0}", numero);
            decimal resultado = 0;

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado + (1.0M / Convert.ToDecimal(i));
            }
            Console.WriteLine("Resultado = {0}", decimal.Round(resultado, 2));
        }
    }
}
