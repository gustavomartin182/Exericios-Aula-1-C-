using System;
using System.Linq;

namespace Exer39
{
    class Program
    {
        public class pessoas
        {
            public double altura { get; set; }
            public int idade { get; set; }
            public double peso { get; set; }
        }
        static void Main(string[] args)
        {
            var pessoa = new pessoas[2];

            for (int i = 0; i < pessoa.Length; i++)
            {
                pessoa[i] = new pessoas();
                Console.WriteLine("Digite a idade da {0}° pessoa.", i + 1);
                pessoa[i].idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura da {0}° pessoa.", i + 1);
                pessoa[i].altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a peso da {0}° pessoa.", i + 1);
                pessoa[i].peso = double.Parse(Console.ReadLine());
            }

            double[] Faixas = new double[3];
            double quantidadePessoas = 0;

            foreach (var pessoasFiltrada in pessoa)
            {
                if (pessoasFiltrada.idade > 50)
                    Faixas[0]++;
                else if ((pessoasFiltrada.idade <= 20) && (pessoasFiltrada.idade >= 10))
                {
                    Faixas[1] += pessoasFiltrada.altura;
                    quantidadePessoas++;
                }
                if (pessoasFiltrada.peso < 40.0)
                    Faixas[2]++;                
            }
            Console.WriteLine("Quantidade de pessoas com mais de 50 anos: {0} ", Faixas[0]);
            Console.WriteLine("Media da alturas de 10 a 20 anos: {0} ", Math.Round(Faixas[1] / quantidadePessoas, 2));
            Console.WriteLine("Percentagem de pessoas com menos de 40 quilos : {0}%", (Faixas[2] * 100) / pessoa.Count());

        }
    }
}
