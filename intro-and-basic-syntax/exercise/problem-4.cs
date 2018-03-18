using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int kcalPer100ml = int.Parse(Console.ReadLine());
            int sugarPer100ml = int.Parse(Console.ReadLine());

            double kcalTotal = ((double)kcalPer100ml * ml)/100.0;
            double sugarTotal = ((double)sugarPer100ml * ml)/ 100.0;

            Console.WriteLine("{0}ml {1}:", ml, name);
            Console.WriteLine("{0}kcal, {1}g sugars", kcalTotal, sugarTotal);




        }
    }
}
