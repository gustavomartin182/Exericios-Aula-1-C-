using System;

namespace Exer4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Digite o valor consumido na mesa.");
            double valorMesa = 0.0;
            valorMesa = double.Parse(Console.ReadLine());
            valorMesa = Math.Round(valorMesa + (0.1 * valorMesa), 2);
            Console.WriteLine(String.Format("O Valor com gorjeta é de: {0}R$", valorMesa));
        }
    }
}
