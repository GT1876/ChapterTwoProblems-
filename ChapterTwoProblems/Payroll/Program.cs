using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {

            String name, ssn, hpr, hw;
            int hourspay, hoursworked;

            double gross, fed, state, moneyperch;

            Console.Write("Enter your name:");
            name = Console.ReadLine();

            Console.Write("Social Security number:");
            ssn = Console.ReadLine();

            Console.Write("Hourly pay rate:");
            hpr = Console.ReadLine();
            hourspay = Convert.ToInt32(hpr); 

            Console.Write("Hours worked:");
            hw = Console.ReadLine();
            hoursworked = Convert.ToInt32(hw);

            gross = hourspay * hoursworked;
            moneyperch = gross / hoursworked;
            fed = gross * 0.15;
            state = gross * 0.05;

            Console.WriteLine();
           
            Console.Write("Payroll Summary for: {0}", name);
            name = Console.ReadLine();

            Console.WriteLine("SSN {0}:", ssn);

            Console.WriteLine("Ypu earned {0} at {1} per hour", gross.ToString("C"), moneyperch.ToString("C"));

            Console.WriteLine("Federal withholding is: {0}", fed.ToString("C"));

            Console.WriteLine("State withholding is: {0}", state.ToString("C"));
        
        }

    }
}
