using System;

namespace Testing
{
    class PetOwner
    {
        public int age { get; set; }
        private List<Animals> Pets = new List<Animals>();
        public void List_animals()
        {

        }
        public void Check_ball()
        {

        }
        public void Fetch()
        {

        }
        public void Feed()
        {

        }
        public void Menu()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Ball
    {
        private string color;
        public int quality { get; set; }
        public Ball(string color)
        {
            this.color = color;
        }
    }
    public abstract class Animals
    {
        protected int age { get; set; }
        protected string name { get; set; }
        protected string fav_food { get; set; }
        protected string breed { get; set; }
        protected bool hungry { get; set; }

        public void Interact(Ball ball)
        {

        }
        public void Eat(string fav_food)
        {

        }
        public void hungry_animal()
        {

        }
        public override string ToString()
        {
            return string.Format(" the animal name is: {0} , and the age is : {1}", name, age);
        }

    }
    class Cat : Animals
    {
        public Cat(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }
        public void hungry_animal()
        {

        }
        public override string ToString()
        {
            return string.Format(" the cat name is: {0} , and the age is : {1}", name, age);
        }
        class Dog : Animals
        {
            public Dog(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

    }







    class fordon
    {
        protected int horsepowers = 900;
        protected string color;

        public fordon(string color, int horsepower)
        {
            this.color = color;
            this.horsepowers = horsepower;
        }

        public virtual void calc_speed()
        {
            int maxspeed = horsepowers;
            int kilo = 200;
            maxspeed = maxspeed - kilo;
            System.Console.WriteLine(" the max speed is: {0}", maxspeed);

        }
        public void horn()
        {
            System.Console.WriteLine("horn horn");
        }

        public void show_color()
        {
            System.Console.WriteLine(" the color of the car is {0}", color);
        }
        public override string ToString()
        {
            return string.Format(" horsepower : {0} HP, color: {1}", horsepowers, color);
        }
    }

    class Lastbil : fordon
    {
        private int last;
        // calc_maxspeed  is calculated by horsepower and last

        public Lastbil(string color, int horsepower, int last) : base(color, horsepower)
        {
            this.last = last;
        }

        public override void calc_speed()
        {
            int maxspeed = horsepowers;

            maxspeed = maxspeed - last;
            System.Console.WriteLine(" the max speed is: {0}", maxspeed);

        }
        public override string ToString()
        {
            return string.Format("this truck has {0}, and cargo: {1} kg", base.ToString(), last);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            fordon myCar = new fordon("black", 1000);
            myCar.horn();
            myCar.show_color();
            myCar.calc_speed();


            Lastbil myLastbil = new Lastbil("yellow", 2400, 1500);
            myLastbil.show_color();
            myLastbil.calc_speed();

            System.Console.WriteLine(myCar);
            System.Console.WriteLine(myLastbil);


            Cat myCat = new Cat("homsi", 34);
            Console.WriteLine(myCat);
            System.Console.WriteLine("end of the line");
            Console.ReadKey();
        }
    }
}
