using System;

namespace Exer15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("{0}.", num1);
            else
                Console.WriteLine("{0}.", num2);
        }
    }
}
