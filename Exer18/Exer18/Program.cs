using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Digite o primeiro número.");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o segundo número");
            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Sort();
            numeros.Reverse();
            foreach (int n in numeros)
            {
                Console.WriteLine("{0}", n);
            }
        }
    }
}
