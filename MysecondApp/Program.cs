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
            int counter = 0;
            string wrong = "\nGuess again: ";

            System.Console.WriteLine("-------------Welcome to the guessing game --------------------\nTry to guess the number");
            System.Console.WriteLine("Please enter a number bewteen 1 and 100: ");
            do
            {

                guessedNumber = int.Parse(Console.ReadLine());
                counter++;

                 // Conditionals if the guessed number is less than 5 away, then print out getting warm, else not even close :)
                if (Math.Abs(guessedNumber - slump_tal) < 5)
                    System.Console.WriteLine("Getting warm..");
                else
                    System.Console.WriteLine("Not even close :)");

               // Conditionals to evaluate if the guessed number is higher or lower than the secret number
                if (guessedNumber > slump_tal)
                    System.Console.WriteLine("The number you have guessed is higher than the secret number! {0}", wrong);

                else if (guessedNumber < slump_tal)
                    System.Console.WriteLine("The number you have guessed is lower than the secret number! {0}", wrong);
                else System.Console.WriteLine("Congratulations!!!! you have guessed the secret number!");

            } while (guessedNumber != slump_tal);

            System.Console.WriteLine("Number of guesses was: " + counter);

            Console.ReadKey(true);
        }
    }
}
