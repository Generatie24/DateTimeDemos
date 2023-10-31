using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime eersteDatum = new DateTime(2023, 10, 28, 23, 16, 38);

            DateTime tweedeDatum = new DateTime(2020, 10, 30, 14, 30, 0);

            TimeSpan verschil = eersteDatum - tweedeDatum;

            Console.WriteLine($"Verschil in dagen: {verschil.Days}");
            Console.WriteLine($"Verschil in uren: {verschil.Hours}");
            Console.WriteLine($"Verschil in minuten: {verschil.Minutes}");
            Console.WriteLine($"Verschil in seconden: {verschil.Seconds}");
            Console.WriteLine($"Total Verschil in minuten: {verschil.TotalMinutes}");

            DateTime nu = DateTime.Now;
            long ticks = tweedeDatum.Ticks;
            Console.WriteLine($"Ticks {ticks} ");


        }
    }
}
