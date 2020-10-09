using System;
using System.Collections.Generic;

namespace Exer22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um número.");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            numeros.Sort();
            numeros.Reverse();
            int maior = numeros[0];
            int intermediario = numeros[1];
            int menor = numeros[2];
            Console.WriteLine("Maior: {0}", maior);
            Console.WriteLine("Intermediario: {0}", intermediario);
            Console.WriteLine("Menor: {0}", menor);
        }
    }
}
