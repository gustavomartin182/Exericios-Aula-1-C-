using System;

namespace Exer24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade.");
            int idade = int.Parse(Console.ReadLine());
            if (idade < 18)
                Console.WriteLine("menor de idade");
            else
            {
                Console.WriteLine("Maior de idade");
                if (idade > 65)
                Console.WriteLine("Maior de 65 anos");
            }
        }
    }
}
