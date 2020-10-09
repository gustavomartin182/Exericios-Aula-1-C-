using System;
using System.Collections.Generic;
using System.Text;

namespace Exer3
{
    class Professor
    {
        public double valorHoraAula { get; set; }
        public double percentualINSS { get; set; }
        public ushort numeroAulas { get; set; }
        public double RetornaSalarioLiquido()
        {
            double Salario = valorHoraAula * numeroAulas;
            Salario = Math.Round(Salario - (Salario * (percentualINSS / 100)), 2);
            return Salario;
        }
        public void ExibeSalario(double Salario)
        {
            Console.WriteLine(String.Format("O Salário liquido deste professor, é: {0}R$", Salario));
        }
    }
}
