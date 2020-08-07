using System;

namespace Tut6_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal cat = new Animal();

            cat.SetName("And");
            cat.Sound = "Meow";

            cat.Owner = "Zam";
            
            Console.WriteLine("the cat name is {0} and {1}", cat.GetName(), cat.Sound);
            Console.ReadLine();
        }

    }
}
