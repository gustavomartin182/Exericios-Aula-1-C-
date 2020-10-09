using System;

namespace Exer33
{
    class Program
    {

        public class clientes
        {
            public string nomes { get; set; }
            public int compras { get; set; }
        }
        static void Main(string[] args)
        {
            var cliente = new clientes[15];

            for (int i = 0; i < cliente.Length; i++)
            {
                cliente[i] = new clientes();
                Console.WriteLine("Digite o nome do {0}° cliente. E o valor das compras", i + 1);
                cliente[i].nomes = (Console.ReadLine());
                Console.WriteLine("Digite o valor das compras deste cliente.");
                cliente[i].compras = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cliente.Length; i++)
            {
                if (cliente[i].compras <= 1000)                
                    Console.WriteLine("Cliente {0} tem o bonues de {1}", cliente[i].nomes, cliente[i].compras * 0.1);                
                else
                    Console.WriteLine("Cliente {0} tem o bonues de {1}", cliente[i].nomes, cliente[i].compras * 0.15);
            }

        }
    }
}
