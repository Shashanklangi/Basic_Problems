using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class Factor
    {
        int i, num;
        public void FactorsProgram()
        {
            Console.WriteLine(" Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; num > 1; i++)
            {
                if (num % i == 0)
                {
                    int x = 0;
                    while (num % i == 0)
                    {
                        num /= i;
                        x++;
                    }
                    Console.WriteLine("{0} is a prime factor {1} times. ", i, x);
                }

            }
        }
    }
}
