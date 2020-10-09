using System;

namespace Exer29
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int i = 1000; i <= 2000; i++)
            {
                if ((i % 11) == 5)
                {
                    Console.WriteLine("Número : {0} sobra : {1}", i, i % 11);
                }
            }
        }
    }
}
