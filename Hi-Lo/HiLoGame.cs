using System;
namespace Hi_Lo
{
    public static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        public static int GetPot()
        {
            return pot;
        }

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(MAXIMUM);

            if((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("You guess right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guess wrong");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"The current number is: {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half) Console.WriteLine($"The number is at least {half}");
            else Console.WriteLine($"The number is at most {half}");

        }
    }
}
