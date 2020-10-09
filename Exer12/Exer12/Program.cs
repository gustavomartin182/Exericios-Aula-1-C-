using System;

namespace Exer12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome.");
            string nome = (Console.ReadLine());

            Console.WriteLine("Digite o sexo, Feminino(F) Masculino(M)");
            string sexo = (Console.ReadLine());

            sexo = sexo.ToUpper();

            Console.WriteLine("Digite sua idade.");           
            byte idade = byte.Parse(Console.ReadLine());

            if ((sexo.Equals("F") || sexo.Equals("FEMININO")) && (idade < 25))
                Console.WriteLine("{0} ACEITA", nome);
            else
                Console.WriteLine("{0} NÃO ACEITA", nome);
        }
    }
}
