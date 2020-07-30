using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_9
{
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}"); 
        }
        //The virtual keyword is used to modify a method, property, indexer, or event declared in the base class and allow it to be overridden in the derived class

        public abstract double Area();
    }
}
