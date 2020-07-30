using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2="grr"
            };
            grover.Sound = "Wooooooof";
            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(1, "Sally");
            grover.SetAnimalIDInfo(2, "Paul");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy: {0}",getHealth.HealthyWeight(11,146));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "EEEEEEEEE"
            };
            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woof",
                Sound2 = "Geeer"
            };

            monkey.MakeSound();
            spot.MakeSound();
            Console.ReadLine();
        }
    }
}
