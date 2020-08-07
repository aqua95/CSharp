using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_11_collections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ArrayList Code

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count: {0} ",aList.Count);

            Console.WriteLine("Count: {0} ", aList.Capacity);

            #endregion

            Console.ReadLine();
        }
    }
}
