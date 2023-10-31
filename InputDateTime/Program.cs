using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een datum en tijd in format (31-12-2022 23:59:59)");

            string input = Console.ReadLine();
            DateTime datumTijd;

            if (DateTime.TryParse(input, out datumTijd))
            {
                Console.WriteLine($"Geldige DateTime {datumTijd.ToString("dd-MM-yyyy")}");
            }
            else
            {
                Console.WriteLine("Ongeldige DateTime ");
            }
        }
    }
}
