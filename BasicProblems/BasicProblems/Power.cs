using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class Power
    {
        public void PowerProgram()
        {
            Console.WriteLine("Enter the value :");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N > 0 && N < 31)
            {
                for (int i = 0; i <= N; i++)
                    Console.WriteLine(2 + " ^ " + i + " = " + Math.Pow(2, i));
            }
            else
            {
                Console.WriteLine("Enter No in range 0 to 30");
            }
        }
    }
}
