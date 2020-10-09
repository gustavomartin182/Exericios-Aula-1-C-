using System;

namespace Exer14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("Os números são iguais.");
            else
                Console.WriteLine("Os números são diferentes.");
        }
    }
}
