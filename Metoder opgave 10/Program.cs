using System;

namespace Metoder_opgave_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 100);
            int guessCounter = 0;
            bool numberFound = false;

            while (numberFound == false)
            {
                Console.WriteLine("Guess the number");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                NumberChecker(secretNumber, userGuess, ref guessCounter, ref numberFound);
            }
            Console.WriteLine("You took " + guessCounter + " tries");
            if (guessCounter < 10)
                Console.WriteLine("Good job!");
            else if (guessCounter < 20)
                Console.WriteLine("Better luck next time");
            else
                Console.WriteLine("That was awful!");
        }
        public static void NumberChecker(int secretNumber, int userGuess, ref int guessCounter,ref bool numberFound)
        {
            if (userGuess < secretNumber)
                Console.WriteLine("The number is bigger\n");
            else if (userGuess > secretNumber)
                Console.WriteLine("The number is smaller\n");
            else if (userGuess == secretNumber)
            {
                Console.WriteLine("You guessed the number!");
                numberFound = true;
            }
            guessCounter++;
        }
    }
}
