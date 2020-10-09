using System;
using System.Linq.Expressions;

namespace Exer27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do cliente.");
            string nome = (Console.ReadLine());
            Console.WriteLine("Digite o valor da compra.");
            decimal valorCompra = decimal.Parse(Console.ReadLine());

            float desconto = 0;
            string resultado = null;
            char primeiraLetra = char.ToUpper(nome[0]);

            if ((primeiraLetra.Equals('A')) ||
                (primeiraLetra.Equals('D')) ||
                (primeiraLetra.Equals('M')) ||
                (primeiraLetra.Equals('S')))
                desconto = 30;
            
            valorCompra = decimal.Round(valorCompra - (valorCompra * (Convert.ToDecimal(desconto) / 100)), 2);
            if (!desconto.Equals(30))
                resultado = "Que pena. Nesta semana não tem desconto para você.";

            Console.WriteLine("O valor da sua compra ficou {0}R$. {1}", valorCompra, resultado);
            
             
            


        }
    }
}
