using System;
using System.Linq;

namespace Exer40
{
    class Program
    {

        public class pessoas
        {
            public double peso { get; set; }
            public int idade { get; set; }
        }
        static void Main(string[] args)
        {
            var pessoa = new pessoas[3];

            for (int i = 0; i < pessoa.Length; i++)
            {
                pessoa[i] = new pessoas();
                Console.WriteLine("Digite a idade da {0}° pessoa.", i + 1);
                pessoa[i].idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o peso da {0}° pessoa.", i + 1);
                pessoa[i].peso = double.Parse(Console.ReadLine());
            }

            double[] Faixas = new double[pessoa.Count()];
            int quantidadePessoas = 0;
            int contador = 0;

            foreach (var pessoasFiltrada in pessoa)
            {
                Faixas[contador] += pessoasFiltrada.idade;
                if (pessoasFiltrada.peso > 90)
                    quantidadePessoas++;
                contador++;
            }
            Console.WriteLine("Quantidade de pessoas com mais de 90 quilos: {0} ", quantidadePessoas);
            Console.WriteLine("Media das idades: {0} ", Math.Round(Faixas.Average()));            
        }
    }
}
