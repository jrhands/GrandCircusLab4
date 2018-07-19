using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            do
            {
                DisplayTable(TakeInput());
            } while (ShouldRepeat());

            Console.WriteLine("\nGoodbye!");
            Console.Read();
        }

        static int TakeInput()
        {
            Console.Write("\nEnter an integer: ");
            return Int32.Parse(Console.ReadLine());
        }

        static void DisplayTable(int userInput)
        {
            Console.WriteLine("\n{0,-15}{1,-15}{2,-15}", "Number", "Squared", "Cubed");
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "=======", "=======", "======");
            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine("{0,-15}{1,-15}{2,-15}", i, (i * i), (i * i * i));
            }
        }

        static bool ShouldRepeat()
        {
            Console.Write("\nContinue? (y/n): ");
            String userInput = Console.ReadLine().ToLower();
            if (userInput == "y" || userInput == "yes")
            {
                return true;
            }
            else if (userInput == "n" || userInput == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return ShouldRepeat();
            }
        }
    }
}
