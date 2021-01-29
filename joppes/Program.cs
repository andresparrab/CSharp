using System;
using System.Collections.Generic;

namespace Testing
{
    class PetOwner
    {
        public int age { get; set; }
        public Ball joppesBall { get; set; }
        private List<Animals> Pets = new List<Animals>();
        private Cat myCatFuji = new Cat("Fuji", 34);
        private NorwegianForestCat myCatThor = new NorwegianForestCat("Thor", 12, "red");
        private Kitten myCatThunder = new Kitten("Thunder", 3, "blue");
        private Dog myDogHunter = new Dog("Hunter", 9);
        private Puppy myPuppyRolf = new Puppy("Rolf", 10);

        public PetOwner(int age)
        {
            this.age = age;
            this.addAnimals(myCatFuji);
            addAnimals(myCatThunder);
            addAnimals(myCatThor);
            addAnimals(myDogHunter);
            addAnimals(myPuppyRolf);

        }

        public void Menu()
        {
            int choice;
            System.Console.WriteLine("\nWelcome to Joppes Animal Family v2");
            // The menu:
            do
            {
                System.Console.WriteLine("-----------------------------------");
                System.Console.WriteLine("\nMenu: ");
                System.Console.WriteLine("1.List pets");
                System.Console.WriteLine("2. Add new pet");
                System.Console.WriteLine("3. Play fetch");
                System.Console.WriteLine("4. Feed your pet");
                System.Console.WriteLine("5. Check balls deteroration");
                System.Console.WriteLine("0. Exit application\n");
                System.Console.WriteLine("Please enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        List_animals();
                        break;
                    case 2:
                        addNewPet();
                        break;
                    case 3:
                        Fetch();
                        break;
                    case 4:
                        Feed();
                        break;
                    case 5:
                        Check_ball(joppesBall);
                        break;
                    case 0:
                        System.Console.WriteLine("Exiting .....");
                        break;
                    default:
                        System.Console.WriteLine(" Please enter a valid choice");
                        break;
                }

            } while (choice != 0);


        }


        public void List_animals()
        {
            int counter = 1;
            System.Console.WriteLine("\nJoppes's pet ares: ");
            foreach (Animals pet in Pets)
            {
                System.Console.WriteLine("{0}. {1}", counter++, pet);
                // System.Console.WriteLine("** {0}, a {1}", pet.animalName(), pet.getBreed());
            }
        }

        public void addNewPet()
        {
            int choice;
            System.Console.WriteLine("Please enter what kind of animal is your new pet:");
            do
            {

                System.Console.WriteLine("\n1. Domestic short-haired cat");
                System.Console.WriteLine("2. Norwegian Forest cat");
                System.Console.WriteLine("3. Norwegian Forest kitten");
                System.Console.WriteLine("4. Northern Inuit");
                System.Console.WriteLine("5. Northern Inuit puppy");
                System.Console.WriteLine("0. Back to the main menu\n");
                System.Console.WriteLine("Please enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("Enter the name, age. (enter each input followed by enter key)");

                        Cat newCat = new Cat(Console.ReadLine(), int.Parse(Console.ReadLine()));
                        addAnimals(newCat);
                        break;
                    case 2:
                        System.Console.WriteLine("Enter the name, age and fur color. (enter each input followed by enter key)");

                        NorwegianForestCat newCatNorwegian = new NorwegianForestCat(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
                        addAnimals(newCatNorwegian);
                        break;
                    case 3:
                        System.Console.WriteLine("Enter the name, age in months and fur color. (enter each input followed by enter key)");

                        Kitten newKittenNorwegian = new Kitten(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
                        addAnimals(newKittenNorwegian);
                        break;
                    case 4:
                        System.Console.WriteLine("Enter the name, age. (enter each input followed by enter key)");

                        Dog newDog = new Dog(Console.ReadLine(), int.Parse(Console.ReadLine()));
                        addAnimals(newDog);
                        break;
                    case 5:
                        System.Console.WriteLine("Enter the name, age in months. (enter each input followed by enter key)");

                        Puppy newPuppy = new Puppy(Console.ReadLine(), int.Parse(Console.ReadLine()));
                        addAnimals(newPuppy);
                        break;
                    case 0:
                        System.Console.WriteLine("Exiting .....");
                        break;
                    default:
                        System.Console.WriteLine(" Please enter a valid choice");
                        break;
                }

            } while (choice != 0);
        }
        public void addAnimals(Animals pet)
        {
            Pets.Add(pet);
        }

        public void Fetch()
        {
            System.Console.WriteLine("Please enter the name of the pet you want to play:");

            string petName = (Console.ReadLine().ToLower());
            System.Console.WriteLine("petsname is: {0}", petName);

            for (int i = 0; i < Pets.Count; i++)
            {
                if ((Pets[i].animalName()).ToLower() == petName)
                {
                    Pets[i].Interact(joppesBall);
                }

            }

        }
        public void Feed()
        {
            System.Console.WriteLine("Please enter the name of the pet you want to feed:");

            string petName = (Console.ReadLine()).ToLower();

            System.Console.WriteLine("Pleaes enter the food you want to feed {0}: ", petName);
            string foodToFeed = Console.ReadLine();

            for (int i = 0; i < Pets.Count; i++)
            {
                if ((Pets[i].animalName()).ToLower() == petName)
                {
                    Pets[i].Eat(foodToFeed);
                }

            }
        }
        public void Check_ball(Ball ball)
        {
            System.Console.WriteLine("the balls deterioration is: {0} %", ball.quality);
            if (ball.quality > 20)
            {
                System.Console.WriteLine("Jeppe looks at the boll, and find it still god for play");

            }
            else if (ball.quality > 0 && ball.quality <= 20)
            {
                System.Console.WriteLine("Jobbe looks at the ball, the {0} color is almost gone.", ball.color);
            }
            else
            {
                System.Console.WriteLine("Hmmm maybe is time to buy a new ball");
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Ball
    {
        public string color;
        public int quality { get; set; }
        public Ball(string color)
        {
            this.color = color;
            this.quality = 100;
        }
        public int Lower_quality(int reduceQuality)
        {
            this.quality -= reduceQuality;
            return quality;
        }
    }
    public abstract class Animals
    {
        protected int age;
        protected string name;
        protected string fav_food;
        protected string breed;
        protected bool hungry;


        public Animals(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string animalName()
        {
            return this.name;
        }
        public string getBreed()
        {
            return this.breed;
        }
        public abstract void Interact(Ball ball);
        public void Eat(string favFood)
        {
            if (fav_food != favFood)
            {
                hungry_animal();
            }
            else
            {
                System.Console.WriteLine("{0} smiles with a big smile and dives right in to the bowl", this.name);
                hungry = false;
            }

        }
        public virtual void hungry_animal()
        {
            System.Console.WriteLine("{0} frowns but have not choice than to eat.", this.name);
        }
        public override string ToString()
        {
            return string.Format(" the animal name is: {0} , and {1} years old", name, age);
        }

    }

    class Dog : Animals
    {
        public Dog(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.breed = "Northern Inuit";
            this.fav_food = "bones";
        }
        public override void Interact(Ball ball)
        {
            ball.Lower_quality(20);
            System.Console.WriteLine("{0 } runs tirelessly after the  {1} color ball, bite it and runs back to Joppe", this.name, ball.color);
        }
        public override string ToString()
        {
            return string.Format("{0} is a {1} Dog , and is {2} years old", name, breed, age);
        }
    }
    class Puppy : Dog
    {
        private int months;
        public Puppy(string name, int months) : base(name, 0)
        {

            this.months = months;

        }

        public override void Interact(Ball ball)
        {
            ball.Lower_quality(10);
            System.Console.WriteLine("{0 } runs happily after the {1} color ball, bite it and runs back to Joppe", this.name, ball.color);
        }
        public override string ToString()
        {
            return string.Format("{0} is a {1} puppy , and is {2} months old", name, breed, months);
        }
    }
    class Cat : Animals
    {
        public Cat(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.fav_food = "fish";
            this.breed = "Domestic short-haired cat";
            this.hungry = true;
        }


        public override void hungry_animal()
        {
            System.Console.WriteLine("{0} rejects the owners food and goes out to for mouse hunting", this.name);
        }
        public override void Interact(Ball ball)
        {
            ball.Lower_quality(15);
            System.Console.WriteLine("{0 } chase the {1} ball all around the house", this.name, ball.color);
        }

        public override string ToString()
        {
            return string.Format("{0} is a {1} , and is {2} years old", name, breed, age);
        }
    }
    class NorwegianForestCat : Cat
    {
        private string Fur_color;
        private bool laid_back;
        public NorwegianForestCat(string name, int age, string Fur_color) : base(name, age)
        {
            this.Fur_color = Fur_color;
            this.laid_back = true;
            this.fav_food = "chicken";
            this.breed = "Norwegian Forest cat";
        }
        public override void Interact(Ball ball)
        {
            ball.Lower_quality(18);
            System.Console.WriteLine("{0 } just looks at the {1} ball in a bored manner", this.name, ball.color);
        }
        public override string ToString()
        {
            return string.Format("{0} is a {1} , and is {2} years old", name, breed, age);
        }
    }
    class Kitten : NorwegianForestCat
    {
        private int months;


        public Kitten(string name, int months, string Fur_color) : base(name, 0, Fur_color)
        {

            this.months = months;
            this.breed = "Norwegian Forest kittie cat";
        }

        public override void Interact(Ball ball)
        {
            ball.Lower_quality(5);
            System.Console.WriteLine("{0} plays with the {1} ball chasing it around with crazy energy", this.name, ball.color);
        }
        public override string ToString()
        {
            return string.Format("{0} is a {1} , and is {2} months old", name, breed, months);
        }
    }








    class Program
    {
        static void Main(string[] args)
        {


            //  ------------------------- Joppes animal family v2 ------------------------------------- //
            // Create ball instance with color
            Ball myball = new Ball("blue");
            // Create the petowner Joppe with give age
            PetOwner Joppe = new PetOwner(39);
            Joppe.joppesBall = myball;
            Joppe.Menu();

            System.Console.WriteLine("end of the line");



        }
    }
}
