using System;

namespace Exer5
{
    class Program
    {
        static void Main(string[] args)
        {
            Poupanca poupanca = new Poupanca();

            Console.WriteLine("Digite o valor constante da aplicação.");
            poupanca.valorConstante = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa da aplicação.");
            poupanca.taxa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de meses de aplicação.");
            poupanca.meses = ushort.Parse(Console.ReadLine());
            poupanca.ExibePoupanca(poupanca.ValorAcumulado());
        }
    }
}
