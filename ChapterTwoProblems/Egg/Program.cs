using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Egg
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = 25;
            int chicken2 = 25;
            int chicken3 = 25;
            int chicken4 = 25;
            int eggs;
            int dozen;

            eggs = chicken + chicken2 + chicken3 + chicken4;
            dozen = eggs / 12;
            eggs = eggs % 12;
            Console.WriteLine("There is {0} dozens and {1} eggs.", dozen, eggs);

 
        }
    }
}
