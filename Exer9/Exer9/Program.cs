using System;

namespace Exer9
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditoEstatuario credito = new CreditoEstatuario();

            Console.WriteLine("Digite o valor do salário bruto.");
            credito.salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da prestação.");
            credito.valorPrestacao = ushort.Parse(Console.ReadLine());

            if ((credito.salarioBruto * 0.3) >= credito.valorPrestacao)
                Console.WriteLine("Empréstimo concedido.");
            else
                Console.WriteLine("Empréstimo negado.");
        }
    }
}
