using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int[] myNumbers = new int[10];
            int[] randomNumbersArray = new int[10];
            Random randomNumber = new Random();

            // Looping trough the array and filling it with random numbers
            for (int i = 0; i < randomNumbersArray.Length; i++)
            {
                randomNumbersArray[i] = randomNumber.Next(1, 10);
            }
            System.Console.WriteLine("[{0}]", string.Join(", ", randomNumbersArray));

            // Game initiation welcome
            System.Console.WriteLine("Welcome to the BINGO game!! \nChoose 10 numbers wisely.");

            // Looping trough the array and filling it with user input numbers
            for (int i = 0; i < myNumbers.Length; i++)
            {
                System.Console.WriteLine("Please enter your lucky numbers:");
                int temp = int.Parse(Console.ReadLine());

                // conditional statment, if the number is between 1-24 then asign the element in index i with the value.
                // else go back 1 index position
                if (temp >= 1 && temp < 25)
                {
                    myNumbers[i] = temp;
                }
                else
                {
                    i--;
                    System.Console.WriteLine("Please enter a number between 1 and 24.");
                }
            }

            // Looping trough both arrays, each element in myNumbers loops trough all numbers in randomNumbersArray
            System.Console.WriteLine("[{0}]", string.Join(", ", myNumbers));
            foreach (int myNumber in myNumbers)
            {
                foreach (int arrayNumber in randomNumbersArray)
                {
                    // condition to validate if the number in both current elements are equal
                    if (myNumber == arrayNumber)
                        System.Console.WriteLine("Congratulations!!!! you hit a winning number: {0}", myNumber);
                }
            }

        }
    }
}

