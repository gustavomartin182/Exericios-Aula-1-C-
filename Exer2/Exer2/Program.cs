using System;

namespace Exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto.");
            decimal valorProduto = 0.0M;
            valorProduto = Convert.ToDecimal(Console.ReadLine());
            valorProduto = decimal.Round(valorProduto - (0.09M * valorProduto), 2);
            Console.WriteLine(String.Format("O Valor com 9% de desconto é: {0}R$", valorProduto));
        }
    }
}
