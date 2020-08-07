using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut7_Inheritence_Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whishkers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr"
            };

            grover.Sound = "Wooooooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Sally");

            grover.SetAnimalIDInfo(123234, "Paul");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my amimal healthy: {0}", getHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeee"
            };
            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "woof",
                Sound2 = "Geeeer"
            };

            monkey.MakeSound();
            spot.MakeSound();

            Console.ReadLine();
        }
    }
}
