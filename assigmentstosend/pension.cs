using System;

namespace pension
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int age;
            int pensionAge = 65;
            int yearsToPension;
            string firtName = "";
            string lastName = "";
            string additionalmessage = "";
            
            // Get the required inputs
            System.Console.WriteLine("Please enter your first name: ");
            firtName = Console.ReadLine();
            System.Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine();
            System.Console.WriteLine("Please enter your age: ");
            age = int.Parse(Console.ReadLine());

            // Calculation
            yearsToPension = pensionAge - age;

            // Condition for the additional message
            if (yearsToPension < 10)
                additionalmessage = "You are almost there!!";
            else
            {
                additionalmessage = "Still many year left, hang in there!";
            }

            //Output message to the user
            string message = string.Format("Hello {0} {1}! it is now {2} years left until you can retire. {3}", firtName, lastName, yearsToPension, additionalmessage);

            System.Console.WriteLine(message);
            Console.ReadKey(true);
        }
    }
}
