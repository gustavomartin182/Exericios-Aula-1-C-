using System;
using System.Collections.Generic;

namespace Exer21
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

            foreach (int n in numeros)
            {
                Console.WriteLine("{0}", n);
            }
        }
    }
}
