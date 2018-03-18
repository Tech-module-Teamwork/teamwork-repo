//CONFIRMED by VladimirD
using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
		//Here we declare 4 variables.We are getting them from the console.The first is string and the next 3 are integers.
            string name = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
		//Here we get the total amount of sugar and kilocalories.
            double kcalTotal = ((double)kcal * ml)/100.0;
            double sugarTotal = ((double)sugar * ml)/ 100.0;
		// Here we print in 2 lines.
            Console.WriteLine("{0}ml {1}:", ml, name);
            Console.WriteLine("{0}kcal, {1}g sugars", kcalTotal, sugarTotal);




        }
    }
}
