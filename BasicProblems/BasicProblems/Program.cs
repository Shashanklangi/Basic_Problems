
namespace BasicProblems
{
    public class Program
    {
        public void FunctionalPrograming()
        {

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for problem.\n");
            Console.WriteLine("1 Largest Number.");
            Console.WriteLine("2 Even and Odd.");

            int problem = Convert.ToInt32(Console.ReadLine());
            Program basic = new Program();
            switch (problem)
            {
                case 1:
                    LargestNumber large = new LargestNumber();
                    large.LargestNumberProgram();
                    break;
                case 2:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.EvenOddProgram();
                    break;
                default:
                    Console.WriteLine("Input is invalid,Enter the number from 1 to 2");
                    break;

            }

        }
    }
}
