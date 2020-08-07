using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut5_Classs_Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.name = "red";
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Rugh"
            };
            Console.WriteLine("{0} is the number of animals", Animal.GetNumAnimals());

            Console.WriteLine("Area of rectangle: {0}", ShapeMath.GetArea("Rectangle", 5, 6));
            Console.ReadLine();

        }
    }
}
