using System;

namespace Exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número.");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            int numero2 = int.Parse(Console.ReadLine());
            if ((numero1 + numero2) > 20)
                Console.WriteLine("{0}", numero1 + numero2 + 8);
            else
                Console.WriteLine("{0}", numero1 + numero2 - 5);
        }
    }
}
