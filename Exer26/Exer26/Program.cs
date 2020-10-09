using System;

namespace Exer26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto.");
            float valorProduto = float.Parse(Console.ReadLine());

            float taxaLucro = 30;

            if (valorProduto < 20.0)
                taxaLucro = 45;
            float valorVenda = valorProduto + (valorProduto * (taxaLucro / 100));
            Console.WriteLine("O valor de venda do produto é: {0}", valorVenda);
        }
    }
}
