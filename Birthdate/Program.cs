using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Birthdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime geboren = new DateTime(1980, 10, 28);
            int oud = DateTime.Now.Year - geboren.Year;//43
            TimeSpan timeSpan = DateTime.Now - geboren;
            Console.WriteLine("timespan " + timeSpan);

            Console.WriteLine($"Je bent {oud} jaar oud");
            Console.WriteLine("maanden " + oud * 12);
            Console.WriteLine("Days " + timeSpan.TotalDays);
            Console.WriteLine("Hours " + timeSpan.TotalHours);
            Console.WriteLine("Minutes " + timeSpan.TotalMinutes);
            Console.WriteLine("Day of year " + geboren.DayOfYear);
            Console.WriteLine("Day of week " + geboren.DayOfWeek);

        }
    }
}
