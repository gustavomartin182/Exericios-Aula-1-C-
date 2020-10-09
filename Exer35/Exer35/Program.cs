using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exer35
{
    class Program
    {
        public class pessoas
        {
            public int idade { get; set; }
        }
        static void Main(string[] args)
        {
            var pessoa = new pessoas[10];

            for (int i = 0; i < pessoa.Length; i++)
            {
                pessoa[i] = new pessoas();
                Console.WriteLine("Digite a idade da {0}° pessoa.", i+1);
                pessoa[i].idade = int.Parse(Console.ReadLine());
            }

            byte quantidadeMenorIdade = 0;

            foreach (var pessoasFiltrada in pessoa)
            {
                if (pessoasFiltrada.idade < 18)
                {
                    quantidadeMenorIdade++;
                }
            }

            Console.WriteLine("Número de pessoas menores de idade {0}.", quantidadeMenorIdade);
            Console.WriteLine("Número de pessoas maiores de idade {0}.", 10 - quantidadeMenorIdade);

        }
    }
}
