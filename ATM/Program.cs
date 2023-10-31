using System;
using System.Text;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal saldo = 1000.00m; // start saldo
            string input;
            int keuze;

            while (true)  
            {
                
                ToonMenu();

                input = Console.ReadLine();
                if (!int.TryParse(input, out keuze))
                {
                    Console.WriteLine("Ongeldige invoer, probeer opnieuw.");
                    continue;
                }

                switch (keuze)
                {
                    case 1:
                        ToonSaldo(saldo);
                        break;
                    case 2:
                        saldo = StortGeld(saldo);
                        break;
                    case 3:
                        saldo = NeemGeldOp(saldo);
                        break;
                    case 4:
                        Console.WriteLine("Bedankt voor het gebruiken van onze ATM. Tot ziens!");
                        return;
                    default:
                        Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                        break;
                }
            }
        }
        static void ToonMenu()
        {
            Console.WriteLine("Kies een optie:");
            Console.WriteLine("1. Bekijk saldo");
            Console.WriteLine("2. Stort geld");
            Console.WriteLine("3. Neem geld op");
            Console.WriteLine("4. Verlaat");
        }
        static void ToonSaldo(decimal saldo)
        {
            Console.WriteLine($"Uw huidige saldo is: €{saldo}");
            ClearScherm();
        }
        static decimal StortGeld(decimal saldo)
        {
            Console.WriteLine("Voer het bedrag in dat u wilt storten:");
            string input = Console.ReadLine();
            decimal bedrag;

            if (decimal.TryParse(input, out bedrag) && bedrag > 0)
            {
                saldo += bedrag;
                Console.WriteLine($"€{bedrag} is gestort. Uw nieuwe saldo is: €{saldo}");
                ClearScherm();
            }
            else
            {
                Console.WriteLine("Ongeldige invoer, probeer opnieuw.");
                ClearScherm();
            }
            
            return saldo;
        }
        static decimal NeemGeldOp(decimal saldo)
        {
            Console.WriteLine("Voer het bedrag in dat u wilt opnemen:");
            string input = Console.ReadLine();
            decimal bedrag;

            if (decimal.TryParse(input, out bedrag) && bedrag > 0)
            {
                if (bedrag <= saldo)
                {
                    saldo -= bedrag;
                    Console.WriteLine($"€{bedrag} is opgenomen. Uw nieuwe saldo is: €{saldo}");
                    ClearScherm();
                }
                else
                {
                    Console.WriteLine("Niet genoeg saldo voor deze opname.");
                    ClearScherm();
                }
            }
            else
            {
                Console.WriteLine("Ongeldige invoer, probeer opnieuw.");
                ClearScherm();
            }

            return saldo;
        }
        private static void ClearScherm()
        {
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}
