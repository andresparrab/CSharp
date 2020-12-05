using System;

namespace Secret_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            Random randomGenerator = new Random();
            int slump_tal = randomGenerator.Next(1, 101);
            int guessedNumber;

            // Get the required inputs
            System.Console.WriteLine("Try to guess the number. \nIs a number between 1 and 100 \nPlease enter a number: ");
            guessedNumber = int.Parse(Console.ReadLine());

            // Conditionals
            if (guessedNumber > slump_tal)
                System.Console.WriteLine("The number you have guessed is higher than the secret number!");
            else
                System.Console.WriteLine("The number you have guessed is lower than the secret number!");

            Console.ReadKey(true);
        }
    }
}
