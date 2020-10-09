using System;

namespace Exer28
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            char ultimoNumero;
            bool validaPlaca = false;

            while (!validaPlaca)
            {
                Console.WriteLine("Digite a placa do seu carro:");
                placa = (Console.ReadLine());
                ultimoNumero = placa[placa.Length - 1];
                validaPlaca = true;

                if (placa.Length.Equals(7))
                {
                    switch (ultimoNumero)
                    {
                        case '1':
                            Console.WriteLine("Seu licenciamento vence em abril");
                            break;
                        case '2':
                            Console.WriteLine("Seu licenciamento vence em maio");
                            break;
                        case '3':
                            Console.WriteLine("Seu licenciamento vence em junho");
                            break;
                        case '4':
                            Console.WriteLine("Seu licenciamento vence em julho");
                            break;
                        case '5':
                            Console.WriteLine("Seu licenciamento vence em agosto");
                            break;
                        case '6':
                            Console.WriteLine("Seu licenciamento vence em agosto");
                            break;
                        case '7':
                            Console.WriteLine("Seu licenciamento vence em setembro");
                            break;
                        case '8':
                            Console.WriteLine("Seu licenciamento vence em outubro");
                            break;
                        case '9':
                            Console.WriteLine("Seu licenciamento vence em novembro");
                            break;
                        case '0':
                            Console.WriteLine("Seu licenciamento vence em dezembro");
                            break;
                        default:
                            Console.WriteLine("Número de placa incorreto, digite novamente.");
                            validaPlaca = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Número de placa não contem 7 digitos, digite novamente.");
                    validaPlaca = false;
                }
            }

        }
    }
}
