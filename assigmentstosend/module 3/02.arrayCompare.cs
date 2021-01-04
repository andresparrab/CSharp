using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 4;
            int[] myNumbers = new int[10];
            for (int i = 0; i < myNumbers.Length; i++)
            {
                System.Console.WriteLine("Please enter a number:");
                int temp = int.Parse(Console.ReadLine());
                myNumbers[i] = temp;
            }
            System.Console.WriteLine("Your numbers are: ");
            System.Console.WriteLine("[{0}]", string.Join(", ", myNumbers));
            foreach (int number in myNumbers)
            {
                if (number == secretNumber)
                    System.Console.WriteLine("The secret number {0} is in the array:", secretNumber);
            }

        }
    }
}
