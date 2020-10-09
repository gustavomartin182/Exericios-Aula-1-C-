using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer32
{
    class Program
    {
        public class conjuntoNumeros
        {
            public int[] grupos { get; set; }
        }

        static void Main(string[] args)
        {            
            var conjuntos = new conjuntoNumeros[5];

            for (int i = 0; i < conjuntos.Length; i++)
            {
                conjuntos[i] = new conjuntoNumeros();
                conjuntos[i].grupos = new int[4];
                for (int t = 0; t <= 3; t++)
                {                    
                    Console.WriteLine("Digite o {0}° numero do grupo {1}", t + 1, i + 1);
                    conjuntos[i].grupos[t] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\r\n Ordem digitada");
            for (int i = 0; i < conjuntos.Length; i++)
            {
                for (int t = 0; t <= 3; t++)
                {
                    Console.WriteLine("Grupo {0} - número {1} ", i + 1, conjuntos[i].grupos[t]);
                }
            }
            Console.WriteLine("\r\n Ordem crescente");

            for (int i = 0; i < conjuntos.Length; i++)
            {
                int[] sortedCopy = conjuntos[i].grupos.OrderBy(i => i).ToArray(); 
                for (int t = 0; t <= 3; t++)
                {
                    Console.WriteLine("Grupo {0} - número {1} ", i + 1, sortedCopy[t]);
                }
            }

            Console.WriteLine("\r\n Ordem decrescente");
            for (int i = 0; i < conjuntos.Length; i++)
            {
                int[] sortedCopy = conjuntos[i].grupos.OrderByDescending(i => i).ToArray();
                for (int t = 0; t <= 3; t++)
                {
                    Console.WriteLine("Grupo {0} - número {1} ", i + 1, sortedCopy[t]);
                }
            }
        }
    }
}
