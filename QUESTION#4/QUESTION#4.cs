using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ClassID: 66318| Registration ID: XXX | Name: MUHAMMAD AEJAZ| Date: 28-10-2026");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
                Console.WriteLine("Result: " + (num1 + num2));
            else if (op == '-')
                Console.WriteLine("Result: " + (num1 - num2));
            else if (op == '*')
                Console.WriteLine("Result: " + (num1 * num2));
            else if (op == '/')
            {
                if (num2 == 0)
                    Console.WriteLine("Cannot divide by zero");
                else
                    Console.WriteLine("Result: " + (num1 / num2));
            }
            else
                Console.WriteLine("Invalid operator");

        }
    }
}
