using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hello, please enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter an operator: ");
            string oP = Console.ReadLine();

            Console.Write("Hello, please a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            if (oP == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (oP == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (oP == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (oP == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }





            Console.ReadLine();



        }
    }
}
