using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassID: 66318 | Registration ID: XXX | Name: MUHAMMAD AEJAZ | Date: 28-10-2026");
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
                Console.WriteLine(year + " is a leap year");
            else if (year % 100 == 0)
                Console.WriteLine(year + " is not a leap year");
            else if (year % 4 == 0)
                Console.WriteLine(year + " is a leap year");
            else
                Console.WriteLine(year + " is not a leap year");
        }
    }
}

