using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            var health = "|" + new string('|', maxHealth - (maxHealth - currentHealth)) + new string('.',maxHealth-currentHealth) + "|";
            var energy = "|" + new string('|', maxEnergy - (maxEnergy - currentEnergy)) + new string('.',maxEnergy-currentEnergy) + "|";

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: {0}", health);
            Console.WriteLine("Energy: {0}", energy);





        }
    }
}
