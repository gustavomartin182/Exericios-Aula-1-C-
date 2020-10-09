using System;

namespace Exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Residencia residencia = new Residencia();

            Console.WriteLine("Digite a quantidade de quilowatts.");
            residencia.quilowatt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do salário mínimo.");
            residencia.salarioMinimo = Convert.ToDecimal(Console.ReadLine());

            decimal valorPorQuilowatt = 0.0M;
            valorPorQuilowatt = decimal.Round((residencia.salarioMinimo / 7) / 100, 2);
            Console.WriteLine(String.Format("O valor de cada quilowatt é de {0}R$", valorPorQuilowatt));
            Console.WriteLine(String.Format("O valor em reais a ser pago {0}R$", valorPorQuilowatt * residencia.quilowatt));
            valorPorQuilowatt = decimal.Round(valorPorQuilowatt - (0.1M * valorPorQuilowatt));
            Console.WriteLine(String.Format("O Valor a ser pago com 10% de desconto {0}R$", valorPorQuilowatt * residencia.quilowatt));
        }
    }
}
