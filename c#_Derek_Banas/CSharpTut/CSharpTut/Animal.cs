using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Animal
    {
        // to not allow inheriting sealed
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} amd is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            :this ("No Name", "No Sound") { }

        public Animal(string name)
            : this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length>10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }


        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double cal = height / weight;

                if ((cal >= .18) && (cal <= 2.7))
                {
                    return true;
                }
                else return false;
            }
        }


    }


}
