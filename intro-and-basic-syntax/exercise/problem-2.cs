//CONFIRMED by VladimirD
using System;

namespace ex2day1
{
    class Program
    {
        static void Main(string[] args)
        {
		//Here we declare 2 variables.We are getting them from the console and parsing them to double.
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
		//Here we are printing the result of a*b with 2 digits after the floating point.
            Console.WriteLine("{0:f2}", num1 * num2);
        }
    }
}