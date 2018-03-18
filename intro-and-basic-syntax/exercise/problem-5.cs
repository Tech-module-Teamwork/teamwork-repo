using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
		//Here we declare 5 variables.We are getting them from the console.The first is string and the next 4 are integers.
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
			//Here we are drawing the health and energy bar.
            var healthBar = "|" + new string('|', maxHealth - (maxHealth - currentHealth)) + new string('.',maxHealth-currentHealth) + "|";
            var energyBar = "|" + new string('|', maxEnergy - (maxEnergy - currentEnergy)) + new string('.',maxEnergy-currentEnergy) + "|";
			//Here we print the name and the health and energy bars.
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: {0}", healthBar);
            Console.WriteLine("Energy: {0}", energyBar);
        }
    }
}
