using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class FlipCoin
    {
        public void FlipCoinProgram()
        {
            int Head = 0;
            int Tail = 0;

            Console.WriteLine("*****Welcome to the flip come*****");

            Console.WriteLine(" Please enter a number of times you want to flip the coin : ");
            int Number_Of_Flips = Convert.ToInt32(Console.ReadLine());

            while (Number_Of_Flips <= 0)
            {
                Console.WriteLine(" Please enter a valid number ");
                Console.WriteLine(" Please enter again ");
                Number_Of_Flips = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Number_Of_Flips; i++)
            {
                Random flip = new Random();
                int Check = flip.Next(0, 2);

                if (Check < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }

            }
            Console.WriteLine("Pecentage of Head(" + Head + "): " + (Head * 100f / (Head + Tail)));
            Console.WriteLine("Percentage of Tail(" + Tail + "): " + (Tail * 100f / (Tail + Head)));
        }
    }
}
