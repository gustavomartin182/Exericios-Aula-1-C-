using System;
using System.Collections.Generic;

namespace Exer23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um número.");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            numeros.Sort();
            numeros.Reverse();
            int maior = numeros[0];
            numeros.Sort();
            int menor = numeros[0];
            Console.WriteLine("Maior: {0}", maior);
            Console.WriteLine("Menor: {0}", menor);
        }
    }
}
