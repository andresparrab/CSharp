using System;

namespace Rounded
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            decimal inputNumner;
            int precision;

            // Get the required inputs
            System.Console.WriteLine("Please enter a float number please use  for the decimal separator ex 1.2345 : ");
            inputNumner = decimal.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter the number of decimals: ");
            precision = int.Parse(Console.ReadLine());
            // Calculation
            decimal rounded = Math.Round(inputNumner, precision);

            //Output message to the user

            string userNumber = string.Format("This is your number with {1} decimals precission: {0} ", rounded, precision);
            string defaultNumber = string.Format("This is your number with default 3 decimals precission:   {0:f} ", Math.Round(inputNumner,3));

            System.Console.WriteLine(userNumber);
            System.Console.WriteLine(defaultNumber);

            Console.ReadKey(true);
        }
    }
}
