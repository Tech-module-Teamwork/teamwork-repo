using System;

namespace ex2day1
{
    class Program
    {
        static void Main(string[] args)
        {
		//Here we declare 2 variables.We are getting them from the console and parsing them to double.
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
		//Here we are printing the result of a*b with 2 digits after the floating point.
            Console.WriteLine("{0:f2}", a * b);
        }
    }
}