using System;

namespace OOP
{

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
    class DogOwner
    {

        public string Name;
        private int Age;
        private dog[] dogs;

        public DogOwner(string _name, int _age)
        {
            Name = _name;
            Age = _age;
            dogs = new dog[2];

        }




        public void fetch()
        {
            foreach (dog item in dogs)
            {
                item.bark();
            }
        }
        public void add_dogs()
        {
            dogs[0] = new dog("Jocke", 2, "tax");
            dogs[1] = new dog("Bosse", 0, "boxer");

        }

        public void show_dogs()
        {
            foreach (dog tempDog in dogs)
            {
                System.Console.WriteLine(tempDog);
            }
        }

        public int calc_age()
        {
            int age = 0;
            foreach (dog temp in dogs)
            {
                age += temp.getAge();
            }

            return age;
        }

    }

    class dog
    {
        public dog(string _name, int _age, string _breed)
        {
            name = _name;
            if (_age < 1)
            {
                age = 1;
            }
            else
                age = _age;
            breed = _breed;
        }
        private string name;
        private int age;
        private string breed;

        public void bark()
        {
            if (age <= 1)
                System.Console.WriteLine("{0} bark with a small voice ", name);
            else
                System.Console.WriteLine("{0} barks like crazy", name);
        }
        public int getAge()
        {
            return age;
        }

        public override string ToString()
        {
            return string.Format("[dog Name = {0}, Age= {1}, Breed = {2}]", name, age, breed);
        }

    }
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
