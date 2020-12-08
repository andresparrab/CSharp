using System;

namespace pension2
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter age :");
            int age = int.Parse(Console.ReadLine());
            int money = 15000;

            do
            {
                if (money < 20000 | age < 65)
                {
                    System.Console.WriteLine("You are saving little");
                    money += 500;
                }
                else
                {
                    System.Console.WriteLine("You are saving a lot");
                    money += 1000;
                }
                age++;

            } while (money < 20000 && age < 65);
            System.Console.WriteLine("You are retired by the age of {0}", age);
            System.Console.WriteLine("You are saved {0} dollars ", money);
            System.Console.WriteLine("press any key to continue....");
            Console.ReadKey();

        }
    }
}
