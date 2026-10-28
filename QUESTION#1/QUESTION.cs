using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassID: 66318 | Registration ID: XXX | Name: muhammad aejaz Date: 28-10-2026");
            Console.Write("Enter day number (1-7): ");



            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
                Console.WriteLine("Monday");
            else if (day == 2)
                Console.WriteLine("Tuesday");
            else if (day == 3)
                Console.WriteLine("Wednesday");
            else if (day == 4)
                Console.WriteLine("Thursday");
            else if (day == 5)
                Console.WriteLine("Friday");
            else if (day == 6)
                Console.WriteLine("Saturday");
            else if (day == 7)
                Console.WriteLine("Sunday");
            else
                Console.WriteLine("Invalid number");
        }
    }
}

