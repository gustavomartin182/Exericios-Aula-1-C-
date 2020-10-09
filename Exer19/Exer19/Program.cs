using System;
using System.Collections.Generic;

namespace Exer19
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

            Console.WriteLine("Digite o terceiro número");
            numeros.Add(int.Parse(Console.ReadLine()));

            numeros.Sort();
            numeros.Reverse();
            Console.WriteLine("{0}", numeros[0]);

        }
    }
}
