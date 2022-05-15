using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class LeapYear
    {
        public void leapyearProgram()
        {
            Console.Write("Enter the Year :");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("Year is Leap Year");
            }
            else
            {
                Console.WriteLine("Year is not a Leap Year");
            }
        }
    }
}
