using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class Harmonic
    {
		public void HarmonicProgram()
		{
			double num = 0, result = 0, i;

			Console.WriteLine(" Enter a number ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (i = 1; i <= n; i++)
			{
				num = num + (1 / i);
				result = num;
			}
			Console.WriteLine("The value of harmonic no. " + n + " is: " + result);
		}
	}
}
