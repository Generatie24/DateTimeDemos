using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            DateTime specifiekeDatum = new DateTime(2023,10,30,14,30,0);
            Console.WriteLine($"Specifiek Datum {specifiekeDatum}");

            Console.WriteLine($"Min value is: {DateTime.MinValue}");
            Console.WriteLine($"Max value is: {DateTime.MaxValue}");

            DateTime nu = DateTime.Now;
            Console.WriteLine(nu);
            //verschilende eigenschapen van datetime
            Console.WriteLine($"Day: {nu.Day}");
            Console.WriteLine($"Month: {nu.Month}");
            Console.WriteLine($"Year: {nu.Year}");
            Console.WriteLine($"Hour: {nu.Hour}");
            Console.WriteLine($"Minute: {nu.Minute}");
            Console.WriteLine($"Second: {nu.Second}");
            Console.WriteLine($"Millisecond: {nu.Millisecond}");
            Console.WriteLine($"Day of week {nu.DayOfWeek}");
            Console.WriteLine($"Day of year {nu.DayOfYear}");

            DateTime nieuweDatum = nu.AddDays(10);
            Console.WriteLine(nieuweDatum);
            DateTime nieuweDatum1 = nu.AddHours(5);
            Console.WriteLine(nieuweDatum1);
            DateTime vorigJaar = nu.AddYears(-1);
            Console.WriteLine(vorigJaar);

        }
    }
}
