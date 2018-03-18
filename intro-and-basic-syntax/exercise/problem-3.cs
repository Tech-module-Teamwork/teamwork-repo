//CONFIRMED by VladimirD
using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
		//Here we declare a variable. We are getting it from the console and parsing it to double.
            double milesInput = double.Parse(Console.ReadLine());
		//Here we convert miles into kilometers.
            double milesToKm = milesInput * 1.60934;
		//Here we print the kilometers with 2 digits after the floating point.
            Console.WriteLine("{0:f2}",milesToKm);
        }
    }
}