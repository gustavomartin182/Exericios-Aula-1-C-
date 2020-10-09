using System;

namespace Exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número.");
            ushort numero = ushort.Parse(Console.ReadLine());
            if (numero > 20)
                Console.WriteLine("{0}", numero);
        }
    }
}
