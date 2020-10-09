using System;

namespace Exer13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o estado.");
            string estado = (Console.ReadLine());
            estado = estado.ToUpper();
            switch(estado)
            {
                case "SP":
                    Console.WriteLine("Paulista.");
                    break;
                case "RJ":
                    Console.WriteLine("Carioca.");
                    break;
                case "MG":
                    Console.WriteLine("Mineiro.");
                    break;
                default:
                    Console.WriteLine("Outros Estados.");
                    break;
            }
        }
    }
}
