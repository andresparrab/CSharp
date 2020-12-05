using System;

namespace SecretNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            Random randomGenerator = new Random();
            int slump_tal = randomGenerator.Next(1, 101);

            // Get the required inputs
            System.Console.WriteLine("Random number : " + slump_tal);

            Console.ReadKey(true);
        }
    }
}
