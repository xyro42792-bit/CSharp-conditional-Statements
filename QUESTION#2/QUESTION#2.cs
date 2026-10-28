using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassID: 66318| Registration ID: XXX | Name: MUHAMMAD AEJAZ| Date: 29-10-2026");
            Console.Write("Enter purchase amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double percent;

            if (amount >= 5000)
                percent = 20;
            else if (amount >= 2000)
                percent = 10;
            else
                percent = 0;

            double discount = amount * percent / 100;
            double finalAmount = amount - discount;

            Console.WriteLine("Discount Percentage: " + percent + "%");
            Console.WriteLine("Discount Amount: " + discount);
            Console.WriteLine("Final Payable Amount: " + finalAmount);

        }
    }
}

