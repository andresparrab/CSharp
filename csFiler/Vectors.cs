using System;

namespace vectorer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vector creation
            int[] mine_numbers = new int[5];

            mine_numbers[0]=13;
            mine_numbers[1]= 8;
            mine_numbers[2]= 20;
            mine_numbers[3]= 22;
            mine_numbers[4]= 11;

            System.Console.WriteLine("please write a number: ");
            mine_numbers[2] = int.Parse(Console.ReadLine());
            // foreach (int number in mine_numbers)
            // {
            //     System.Console.WriteLine(number);
            // }

            for (int i = 0;  i < mine_numbers.Length; i++)
            {
                int lastIndex = mine_numbers.Length -1;
                System.Console.WriteLine("Indexposition has the index: {0} and  value: {1} ", i, mine_numbers[lastIndex -i]);
            }
            Console.ReadKey();
        }
    }
}


    class Human
    {
        // components
        private int arms = 2, legs = 2, head = 1;
        //propertyes
        public string hariColor, name;
        public int lenght;

        //methods
        public void Run(int speed)
        {
            // logic for run speed
        }
        public void Jump()
        {
            // logig for jumping
        }
        public void Talk(string message)
        {
            System.Console.WriteLine(message);
        }
    }