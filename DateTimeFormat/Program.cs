using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //DateTime eersteDatum = new DateTime(2023, 10, 28, 23, 16, 38);
            DateTime nu = DateTime.Now;

            Console.WriteLine(nu.ToLongDateString()); // 
            Console.WriteLine(nu.ToShortDateString());
            Console.WriteLine(nu.ToLongTimeString());
            Console.WriteLine(nu.ToShortTimeString());

            Console.WriteLine(nu.ToString("dd-MM-yyyy"));
            Console.WriteLine(nu.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(nu.ToString("MM-dd-yyyy"));
            Console.WriteLine(nu.ToString("MM-dd-yyyy HH:mm:ss"));
            Console.WriteLine(nu.ToString("yyyy-MM-dd"));
        }
    }
}
