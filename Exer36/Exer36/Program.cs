using System;

namespace Exer36
{
    class Program
    {
        public class pessoas
        {
            public int idade { get; set; }
        }
        static void Main(string[] args)
        {
            var pessoa = new pessoas[15];

            for (int i = 0; i < pessoa.Length; i++)
            {
                pessoa[i] = new pessoas();
                Console.WriteLine("Digite a idade da {0}° pessoa.", i + 1);
                pessoa[i].idade = int.Parse(Console.ReadLine());
            }
            
            byte[] Faixas = new byte[5];

            foreach (var pessoasFiltrada in pessoa)
            {
                if (pessoasFiltrada.idade <= 15)
                    Faixas[0]++;
                else if (pessoasFiltrada.idade <= 30)
                    Faixas[1]++;
                else if (pessoasFiltrada.idade <= 45)
                    Faixas[2]++;
                else if (pessoasFiltrada.idade <= 60)
                    Faixas[3]++;
                else 
                    Faixas[4]++;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Faixa etaria {0} {1} pessoas {2}%.",i + 1, Faixas[i], (Faixas[i] * 100)/15);               
            }

        }
    }
}
