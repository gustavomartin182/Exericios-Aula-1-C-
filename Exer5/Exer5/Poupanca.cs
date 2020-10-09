using System;
using System.Collections.Generic;
using System.Text;

namespace Exer5
{
    class Poupanca
    {
        public double valorConstante { get; set; }
        public double taxa { get; set; }
        public ushort meses { get; set; }

        public double ValorAcumulado()
        {
            double valor = Math.Round(valorConstante * (Math.Pow((1 + taxa), meses)) / taxa, 2);          
            return valor;
        }
        public void ExibePoupanca(double valor)
        {
            Console.WriteLine(String.Format("Valor poupança, é: {0}R$", valor));
        }
    }
}
