using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome.");
            string nome = (Console.ReadLine());

            Console.WriteLine("Digite a nota da sua PR1.");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da sua PR2.");
            float nota2 = float.Parse(Console.ReadLine());

            string resultado;

            List<float> notas = new List<float>
            {
                nota1,
                nota2
            };

            if (notas.Average() >= 7)
                resultado = "APROVADO!";
            else if (notas.Average() < 3)
                resultado = "REPROVADO!";
            else
                resultado = "de EXAME!";


            Console.WriteLine("O aluno {0} com nota de PR1 {1} e nota de PR2 {2}.", 
                nome, nota1, nota2);
            Console.WriteLine("Teve a média de {0}. E por conta disto, esta oficialmente {1}", 
                notas.Average(), resultado);     

        }
    }
}
