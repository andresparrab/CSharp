using System;

namespace Bastu
{


    class Program
    {
        public static double FahrToCels(int fahr)
        {
            double temp = ((double)fahr - 32) * 5 / 9;
            return temp;
        }

        public static double FahrToCels()
        {
            double fahr = new Random().Next(150, 191);
            System.Console.WriteLine("This is the random temperature: " + fahr);
            double temp = (fahr - 32) * 5 / 9;
            return temp;
        }
        static void Main(string[] args)
        {
            double celsius = 0;
            int fahrenheit = 0;
            do
            {
                System.Console.WriteLine("Enter the temperature in Fahrenheit: ");

                try
                {

                    fahrenheit = int.Parse(Console.ReadLine());
                    if (fahrenheit == 0)
                        celsius = FahrToCels();
                    else
                        celsius = FahrToCels(fahrenheit);
                }
                catch (System.Exception error)
                {
                    System.Console.WriteLine("Error found");
                    System.Console.WriteLine(error);
                }





                if (celsius <= 73)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine("Is to cold. Please tur up the temperature a little bit.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    System.Console.WriteLine("Is to hot. Please turn dow the heat a little bit.");
                    Console.ResetColor();

                }


            } while (celsius < 73 || celsius > 77);
            System.Console.WriteLine("This is an acceptable temperature! ");
            System.Console.WriteLine("in celsius it would be: {0:f1} °C ", celsius);
            System.Console.WriteLine("press any key to continue....");
            Console.ReadKey();

        }
    }


}
