using System.Diagnostics;

namespace SlotMachine
{
    internal class Program
    {
        public const int max_lines = 3;
        public const int min_bet = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines to bet on ");
            int bet = int.Parse(Console.ReadLine());
            Console.WriteLine("What amount would like to deposit ");
            int deposit  = depositAmount(int.Parse(Console.ReadLine()));
            double stake = bet * deposit;
            Console.WriteLine(stake);
            Console.WriteLine("what would you like to bet on each line?");
            Console.WriteLine(getBet(int.Parse(Console.ReadLine())));
        }

        static int depositAmount(int input)
        {
            while (true)
            {
                if (input > 0)
                {
                    break; 
                }
                else {
                    Console.WriteLine("Amount must be greater than 0 ");
                }
            }
            return input;
        }
        static int getnumberoflines(int lines)
        {
            while (true)
            {
                if (lines > 0 && lines < 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid number of lines.");
                }
            }
            return lines;
        }
        static int getBet(int bet)
        {
            int max_bet = 100;
            int min_bet = 1;
            while (true)
            {
                if (bet >= min_bet && bet <= max_bet)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"The amount to bet must be between {max_bet} and {min_bet}");
                }
            }
            return bet;
        }
    }
}