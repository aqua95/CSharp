using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_10_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);

            if(buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven",buick.Brand);
            }

            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powerButton = new PowerButton(TV);

            powerButton.Execute();
            powerButton.Undo();
            Console.ReadLine();
        }
    }
}
