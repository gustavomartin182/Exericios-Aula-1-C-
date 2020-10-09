using System;

namespace Exer34
{
    class Program
    {

        public class VendasIngressos
        {
            public decimal precoPorIngresso { get; set; }
            public decimal numIngressosVendidos { get; set; }
            public decimal despesas { get; set; }
            public decimal lucro { get; set; }
        }

        static void Main(string[] args)
        {
            decimal valorIngresso = 45.0M;
            decimal despesaPorIngresso;
            int IngressosVendido = 120;
            const int AumentoPorPreco = 26;

            despesaPorIngresso = 200 / 120;

            var vendas = new VendasIngressos[90];

            for (int i = 0; i < vendas.Length; i++)
            {
                vendas[i] = new VendasIngressos();
                valorIngresso -= 0.5M;
                vendas[i].precoPorIngresso = valorIngresso;
                IngressosVendido += 26;
                vendas[i].numIngressosVendidos = IngressosVendido;
                vendas[i].despesas = IngressosVendido * despesaPorIngresso;
                vendas[i].lucro = (IngressosVendido * valorIngresso) - vendas[i].despesas;

                Console.WriteLine("Preço do ingresso: {0}R$; Ingressos Vendidos {1}.", vendas[i].precoPorIngresso, vendas[i].numIngressosVendidos);
                Console.WriteLine("Despesas: {0}R$; Lucro: {1}R$.", vendas[i].despesas, vendas[i].lucro);
            }

        }
    }
}
