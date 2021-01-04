using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[10];
            for (int i = 0; i < myNumbers.Length; i++)
            {
                System.Console.WriteLine("Please enter a number:");
                int temp = int.Parse(Console.ReadLine());
                myNumbers[i] = temp;
            }
 
        }
    }
}
