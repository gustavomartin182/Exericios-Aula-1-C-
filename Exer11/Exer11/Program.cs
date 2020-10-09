using System;

namespace Exer11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número.");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 20)
                Console.WriteLine("Maior que 20.");
            else if (numero == 20)
                Console.WriteLine("Igual a 20.");
            else
                Console.WriteLine("Menor que 20.");
        }
    }
}
