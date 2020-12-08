using System;

namespace vectorer
{
    class Program
    {

        static void Main(string[] args)
        {
            car myCar = new car("Toyota", 1000);
            myCar.run();
            // myCar.horn();
            // myCar.board();

            System.Console.WriteLine("press any key to continue....");
            Console.ReadKey();

        }
    }

    class car
    {
        private string name;
        private int horsepower;
        private int[] passengers;

        public car(string _name, int _horsepower)
        {
            name = _name;
            horsepower = _horsepower;
            passengers = new int[4];
        }
        public void run()
        {

            int temp = 0;
            do
            {
                System.Console.WriteLine("Choose the option:");
                System.Console.WriteLine("1. horn ");
                System.Console.WriteLine("2. board ");
                System.Console.WriteLine("3. calculate top speed ");
                System.Console.WriteLine("0. Quit ");
                temp = int.Parse(Console.ReadLine());


                switch (temp)
                {
                    case 1:
                        horn();
                        break;
                    case 2:
                        board();
                        break;
                    case 3:
                        max_speed();
                        break;
                    case 0:
                        System.Console.WriteLine("Quit the app.");
                        break;
                    default:
                        Console.WriteLine("Wrong input..");
                        break;
                }
            } while (temp != 0);
        }
        public void horn()
        {
            Console.WriteLine("bilen {0} sounded the horn! ", name);
        }
        public void board()
        {
            Random random = new Random();
            for (int x = 0; x < passengers.Length; x++)
            {
                int temp = random.Next(50, 100);
                passengers[x] = temp;
            }
            System.Console.WriteLine(" passengers total weight is: {0}  has boarded the vehicle", passengers);

        }
        public int max_speed()
        {
            int kilo = 0;
            int maxSpeed = horsepower;

            foreach (int passenger in passengers)
            {
                kilo += passenger;

            }
            kilo *= 2;
            maxSpeed -= kilo;
            System.Console.WriteLine("The car max speed is {0} km/h", maxSpeed);
            return maxSpeed;
        }

    }
}
