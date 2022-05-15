using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class SwapNumber
    {
        public void SwapNumberProgram()
        {

            int temp;
            Console.WriteLine("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;


            Console.WriteLine("After Swap num1 = " + num1);
            Console.WriteLine("After Swap num2 = " + num2);
        }
    }
}
