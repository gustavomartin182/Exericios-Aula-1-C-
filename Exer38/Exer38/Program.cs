using System;

namespace Exer38
{
    class Program
    {
        public class vendas
        {
            public char codigo { get; set; }
            public decimal valor { get; set; }
        }
        static void Main(string[] args)
        {
            var venda = new vendas[15];

            for (int i = 0; i < venda.Length; i++)
            {
                venda[i] = new vendas();
                Console.WriteLine("Digite o código da {0}° venda.", i + 1);
                venda[i].codigo = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da {0}° venda.", i + 1);
                venda[i].valor = decimal.Parse(Console.ReadLine());
            }

            decimal valorTotalVista = 0M;
            decimal valorTotalPrazo = 0M;
            decimal valorTotal = 0M;
            decimal valorTotalPrazoPrimeira = 0M;

            foreach (var vendasFiltradas in venda)
            {
                switch (Char.ToUpper(vendasFiltradas.codigo))
                {
                    case 'V':
                        valorTotalVista += vendasFiltradas.valor;
                        valorTotal += vendasFiltradas.valor;
                        break;
                    case 'P':
                        valorTotalPrazo += vendasFiltradas.valor;
                        valorTotal += vendasFiltradas.valor;
                        break;
                    default:
                        break;
                }
            }

            valorTotalPrazoPrimeira = valorTotalPrazo / 3;

            Console.WriteLine("Valor total das compras {0}R$", valorTotal);
            Console.WriteLine("Valor total das compras à vista {0}R$", valorTotalVista);
            Console.WriteLine("Valor total das compras à prazo {0}R$", valorTotalPrazo);
            Console.WriteLine("Valor da primeira parcela das compras à prazo {0}R$", Decimal.Round(valorTotalPrazoPrimeira), 2);

        }
    }
}
