using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut6_Constructor
{
    class Animal
    {

        private string name;
        private string sound;

        public const string SHELTER = "Animals Home";

        public readonly int idNum; //constant change at run time
        
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        //pass defaults up the chain to constructor
        public Animal()
            : this("No Name", "No Sound") { }

        public Animal(string name)
            : this(name, "No Sound") { }

        public Animal(string name,string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;

            Random rnd = new Random();
            idNum = rnd.Next(1, 214742781);
        }
        
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name cant contain numbers");
            }
        }

        public string GetName()
        {
            return name;
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value; //value is the default variable passed in the setter
                }
            }
        }
        public string Owner { get; set; } = "No owner";

        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
            


    }
}
