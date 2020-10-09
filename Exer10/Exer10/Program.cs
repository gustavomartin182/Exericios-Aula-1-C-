using System;

namespace Exer10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número.");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 20 && numero < 90)
                Console.WriteLine("Esta compreendido.");
            else
                Console.WriteLine("Não esta compreendido.");
        }
    }
}
