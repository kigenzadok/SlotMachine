namespace SlotMachine
{
    internal class Program
    {
        int max_lines = 3;
        static void Main(string[] args)
        {
            depositAmount(3);
        }

        static int depositAmount(int input)
        {
            while (true)
            {
                Console.WriteLine("What amount would like to deposit ");
                input = int.Parse(Console.ReadLine());
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
                Console.WriteLine("What amount would like to deposit ");
                lines = int.Parse(Console.ReadLine());
                if (lines > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Amount must be greater than 0 ");
                }
            }
            return lines;
        }
    }
}