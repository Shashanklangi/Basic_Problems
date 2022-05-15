using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class LargestNumber
    {
        public void LargestNumberProgram()
        {
            Console.WriteLine("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("First number is the largest number:" + num1);
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Second number is the largest number:" + num2);
            }
            else
            {
                Console.WriteLine("Third number is the largest number:" + num3);
            }
        }
    }
}
