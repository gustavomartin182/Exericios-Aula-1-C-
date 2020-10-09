using System;

namespace Exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();

            Console.WriteLine("Digite o valor da hora aula.");
            professor.valorHoraAula = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de aulas dadas neste mês.");
            professor.numeroAulas = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual de desconto do INSS.");
            professor.percentualINSS = double.Parse(Console.ReadLine());
            professor.ExibeSalario(professor.RetornaSalarioLiquido());
        }
    }
}
