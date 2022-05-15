
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
            Console.WriteLine("2 Even and Odd Number.");
            Console.WriteLine("3 Harmonic Number.");
            Console.WriteLine("4 Flip Coin.");
            Console.WriteLine("5 Leap Year");
            Console.WriteLine("6 Swap Numbers.");
            Console.WriteLine("7 Power of 2.");
            Console.WriteLine("8 Vowels.");
            Console.WriteLine("9 Prime factorisation.");

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
                case 3:
                    Harmonic harmonic = new Harmonic();
                    harmonic.HarmonicProgram();
                    break;
                case 4:
                    FlipCoin coin = new FlipCoin();
                    coin.FlipCoinProgram();
                    break;
                case 5:
                    LeapYear leap = new LeapYear();
                    leap.leapyearProgram();
                    break;
                case 6:
                    SwapNumber swap = new SwapNumber();
                    swap.SwapNumberProgram();
                    break;
                case 7:
                    Power power = new Power();
                    power.PowerProgram();
                    break;
                case 8:
                    Vowels vowels = new Vowels();
                    vowels.VowelsProgram();
                    break;
                case 9:
                    Factor factor = new Factor();
                    factor.FactorsProgram();
                    break;
                default:
                    Console.WriteLine("Input is invalid,Enter the number from 1 to 9");
                    break;

            }

        }
    }
}
