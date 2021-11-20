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
            int contor = 0;
            bool isRunning = true;
            Console.WriteLine("Bine ati venit! Aveti doua optiuni:");
            Console.WriteLine("1 - introduceti monede.");
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
                Console.WriteLine();
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

                            if (contor < 20)
                            {
                                Console.WriteLine("Nu puteti achizitiona marfa");
                            }
                            else if (contor == 20)
                            {
                                Console.WriteLine("Primiti marfa fara rest");
                            }
                            else
                            {
                                contor -= 20;
                                Console.WriteLine($"Primiti marfa si restul este {contor}. ");
                                if (contor == 5)
                                {
                                    Console.WriteLine("Primiti rest un nickel");
                                    contor -= 5;
                                    Console.WriteLine($"In aparat raman {contor} centi");
                                }
                                if (contor == 10)
                                {
                                    Console.WriteLine("Primiti rest un dime");
                                    contor -= 10;
                                    Console.WriteLine($"In aparat raman {contor} centi");
                                }
                                if (contor == 15)
                                {
                                    Console.WriteLine("Primiti rest un nickel si un dime");
                                    contor -= 15;
                                    Console.WriteLine($"In aparat raman {contor} centi");
                                }
                                if (contor >= 20)
                                {
                                    Console.WriteLine("Primiti rest un nickel si un dime");
                                    contor -= 15;
                                    Console.WriteLine($"In aparat raman {contor} centi");
                                }
                            }
                        }
                        break;
                    case 2:
                        input = false;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida");
                        break;
                }
            }
        }
    }
}
