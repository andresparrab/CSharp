using System;

namespace BusApp
{
    class passengers
    {

        public int age, salary;
        public string gender;
        public passengers(int _age, string _gender, int _salary)
        {
            age = _age;
            gender = _gender;
            salary = _salary;
        }



        public void poke()
        {
            if (gender == "man" && age < 20)
            {
                System.Console.WriteLine("He just look at you without any care and continue playing on his phone");
            }
            if (gender == "man" && age > 20 && age < 40)
            {
                System.Console.WriteLine("The passenger says: quit it!!");
            }
            if (gender == "man" && age > 40)
            {
                System.Console.WriteLine("He frowns");
            }
            if (gender == "woman" && age < 30)
            {
                System.Console.WriteLine("She say, hey you watch it !!!");
            }
            if (gender == "woman" && age > 30)
            {
                System.Console.WriteLine("She says: this is not acceptable behavior!!!");
            }
        }

    }
    class Bus
    {
        private int passengersCount = 0;
        private passengers[] newPassengersGroup = new passengers[10];
        private int ticketPrice = 25;

        private Random randomizer = new Random();


        public int get_ticketPrice()
        {
            return ticketPrice;
        }

        public void Run()
        {
            int choice;
            System.Console.WriteLine("Welcome to the awsome Buss-simulator");
            do
            {
                System.Console.WriteLine("----------------------------------------------------------------");
                System.Console.WriteLine("1. Add a passenger");
                System.Console.WriteLine("2. Print out the buss");
                System.Console.WriteLine("3. Calculate the total age of the passengers");
                System.Console.WriteLine("4. Calculate the average age of the passengers");
                System.Console.WriteLine("5. Calculate the max age");
                System.Console.WriteLine("6. Find an age: ");
                System.Console.WriteLine("7. Print the genders positions");
                System.Console.WriteLine("8. Sort bus");
                System.Console.WriteLine("9. Getting off");
                System.Console.WriteLine("10. Poke");
                System.Console.WriteLine("11. Get ticket price: ");
                System.Console.WriteLine("0. Exit the program");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        add_passenger();
                        break;
                    case 2:
                        print_buss();
                        break;
                    case 3:
                        // calc_total_age();
                        System.Console.WriteLine("passengers ages: {0} ", calc_total_age());
                        break;
                    case 4:
                        calc_average_age();
                        break;
                    case 5:
                        System.Console.WriteLine("The max age is: {0}", max_age());
                        break;
                    case 6:
                        find_age();
                        break;
                    case 7:
                        print_sex();
                        break;
                    case 8:
                        sort_buss();
                        break;
                    case 9:
                        getting_off();
                        break;
                    case 10:
                        poke();
                        break;
                    case 11:
                        System.Console.WriteLine("The price oc the ticket is: {0} ", get_ticketPrice());
                        break;

                    case 0:
                        System.Console.WriteLine("Exiting ...");
                        break;


                }
            } while (choice != 0);

        }

        public void add_passenger()
        {

            for (int i = 0; i < newPassengersGroup.Length; i++)
            {
                if (newPassengersGroup[i] == null)
                {
                    // Random randomizer = new Random();
                    int age = randomizer.Next(13, 89);
                    int salary = randomizer.Next(15000, 80000);
                    string[] genders = { "man", "woman" };
                    string gender = genders[randomizer.Next(0, genders.Length)];
                    System.Console.WriteLine("there is an empty seat");
                    newPassengersGroup[i] = new passengers(age, gender, salary);
                    System.Console.WriteLine("Passengers age: {0} ", newPassengersGroup[i].age);
                    System.Console.WriteLine("Passenger gender: {0} ", newPassengersGroup[i].gender);

                    if (passengersCount == 0)
                    {
                        passengersCount = 1;
                    }
                    else
                    {
                        passengersCount++;
                    }
                    break;
                }
            }
            if (newPassengersGroup[newPassengersGroup.Length - 1] != null)
            {
                System.Console.WriteLine("Sorry there are not more empty seats");
            }

        }

        public void print_buss()
        {
            foreach (passengers currentPassenger in newPassengersGroup)
            {
                if (currentPassenger != null)
                {
                    System.Console.WriteLine("SeatAge [{0}]", currentPassenger.age);

                }
                else
                {
                    System.Console.WriteLine("no passenger");
                }
            }


        }


        public int calc_total_age()
        {
            int total = 0;
            foreach (passengers currentPassenger in newPassengersGroup)
            {
                if (currentPassenger != null)
                {
                    total += currentPassenger.age;


                }
                else
                {
                    System.Console.WriteLine("No passenger here");
                }
            }

            return total;

        }

        public void calc_average_age()
        {


            float average = (float)calc_total_age() / (float)passengersCount;

            System.Console.WriteLine("The average is : {0:f2}", average);
        }

        public int max_age()
        {
            int compare = newPassengersGroup[0].age;
            for (int i = 0; i < newPassengersGroup.Length; i++)
            {

                if (compare < newPassengersGroup[i].age)
                    compare = newPassengersGroup[i].age;
            }
            return compare;
        }

        public void find_age()
        {
            System.Console.WriteLine("Please enter the age you wish to find: ");
            int age = int.Parse(Console.ReadLine());

            for (int i = 0; i < newPassengersGroup.Length; i++)
            {

                if (age == newPassengersGroup[i].age)
                {
                    System.Console.WriteLine("\nage {0} found\n", age);
                    break;
                }
                else if (age != newPassengersGroup[newPassengersGroup.Length - 1].age)
                {
                    System.Console.WriteLine("Age not found anywhere in the bus");

                }

            }


        }



        public void sort_buss()
        {

            passengers compare = newPassengersGroup[0];
            passengers temp = new passengers(0, "", 0);
            // int j = 1;

            for (int j = 0; j <= newPassengersGroup.Length - 2; j++)
            {
                for (int i = 0; i <= newPassengersGroup.Length - 2; i++)
                {
                    if (newPassengersGroup[i] != null && newPassengersGroup[i + 1] != null)
                    {
                        if ((newPassengersGroup[i].age > newPassengersGroup[i + 1].age))
                        {
                            temp = newPassengersGroup[i + 1];
                            newPassengersGroup[i + 1] = newPassengersGroup[i];
                            newPassengersGroup[i] = temp;
                        }
                        //System.Console.WriteLine("passengers sorted: {0}", newPassengersGroup[i].age);
                    }
                    else if (newPassengersGroup[i] == null && newPassengersGroup[i + 1] == null)
                    {
                        System.Console.WriteLine("not enough passenger to sort the ages");
                        break;
                    }

                }


            }
            print_buss();

            // for (int i = 0; i < newPassengersGroup.Length && j < newPassengersGroup.Length; i++, j++)
            // {
            //     if (newPassengersGroup[i] != null && newPassengersGroup[j] != null)
            //     {

            //         if ((newPassengersGroup[i].age > newPassengersGroup[j].age))
            //         {
            //             temp = newPassengersGroup[i];
            //             newPassengersGroup[i] = newPassengersGroup[j];
            //             newPassengersGroup[j] = temp;
            //             j--;
            //         }
            //         System.Console.WriteLine("passengers sorted: {0}", newPassengersGroup[i].age);
            //     }

            // }
            // System.Console.WriteLine("not enough passenger to sort the ages");

        }

        public void print_sex()
        {
            int maleIndex;
            int femaleIndex;
            for (int i = 0; i < newPassengersGroup.Length; i++)
            {
                if (newPassengersGroup[i].gender == "man")
                {
                    maleIndex = i;
                    System.Console.WriteLine("a man is sitting in index {0}", string.Join(",", maleIndex));
                }
                else
                {
                    femaleIndex = i;
                    System.Console.WriteLine("a woman is sitting in index {0}", string.Join(",", femaleIndex));
                }
            }
        }

        public void poke()
        {

            int seat = randomizer.Next(0, passengersCount);
            if (newPassengersGroup[seat] != null)
            {
                newPassengersGroup[seat].poke();
            }
            else
            {
                System.Console.WriteLine("Noone to poke in this seat.");
            }
        }

        public void getting_off()
        {
            for (int i = 0; i < newPassengersGroup.Length; i++)
            {
                if (newPassengersGroup[i] != null)
                {
                    System.Console.WriteLine("passengerCount is {0}", randomizer.Next(0, passengersCount));
                    newPassengersGroup[randomizer.Next(0, passengersCount - 1)] = null;
                    print_buss();
                    passengersCount--;
                    break;
                }
                else
                {
                    System.Console.WriteLine("no passengers omboard");
                }
            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bus minbuss = new Bus();
            minbuss.Run();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

