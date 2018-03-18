using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
			//Here we declare 4 variables.We are getting them from the console and parsing them to integer.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
				// Here we are printing all variables with 4 digits limit each.
            Console.WriteLine("{0:d4} {1:d4} {2:d4} {3:d4}", a, b, c, d);
        }
    }
}