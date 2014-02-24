using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 11, width = 25;
            int area = length * width;
            double price = 3.27;
            double cost = price * area;
            Console.WriteLine("The carpet will cost {0}", cost.ToString("C")); 
 
        }
    }
}
