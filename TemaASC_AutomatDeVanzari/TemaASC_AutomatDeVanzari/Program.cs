using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaASC_AutomatDeVanzari
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 5;
            //int d = 10;
            //int q = 25;
            int contor = 0;
            bool isRunning = true;
            Console.WriteLine("Bine ati venit! Aveti doua optiuni:");
            Console.WriteLine("1 - introduceti monede.");
            Console.WriteLine("2 - scoateti marfa.");
            Console.WriteLine("0 - La revedere.");
            while (isRunning)
            {
                int optiune = int.Parse(Console.ReadLine());
                switch (optiune)
                {
                    case 0:
                        break;
                    case 1:
                        InputMoney(ref contor);
                        break;
                    case 2:
                        OutputMerchandise(ref contor);
                        break;
                    default:
                        Console.WriteLine("Optiune invalida");
                        break;
                }
            }
        }
        private static void InputMoney(ref int contor)
        {
            Console.WriteLine("Introduceti moneda: (monedele acceptate sunt 5, 10, 25)");
            bool input = true;
            
            while (input)
            {
                Console.WriteLine("Vreti sa introduceti monede?");
                Console.WriteLine(" 1. DA");
                Console.WriteLine(" 2. NU");

                int optiune = int.Parse(Console.ReadLine());
                switch (optiune)
                {
                    case 1:
                        Console.WriteLine("Tipul monedei: ");
                        int n = int.Parse(Console.ReadLine());
                        if (n != 5 && n != 10 && n != 25)
                        {
                            Console.WriteLine("Moneda invalida. Incercati din nou");
                        }
                        else
                        {
                            contor += n;
                            Console.WriteLine($"In aparat sunt {contor} centi.");
                        }
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Optiune invalida");
                        break;
                }
            }
        }
        private static void OutputMerchandise(ref int contor)
        {

        }
    }
}
