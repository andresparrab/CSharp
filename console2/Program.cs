using System;
using System.Collections.Generic;

namespace console2
{
    class Program
    {
        List<string> names = new List<string>() { "Susan", "Andres", "Carl", "Andres", "jonte", "Hom", "Viktor", "Hom", "Erwin", "Hom" };


        static void Main(string[] args)
        {
            Program prog = new Program();
            List<string> personer = new List<string>();
            personer.Add("Bengt");
            personer.AddRange(new string[] { "Susan", "Sara", "Carl", null, null, "Viktor" });
            personer.Sort();
            foreach (string name in personer)
            {
                System.Console.WriteLine(name);
            }

            Console.WriteLine(personer[0]);
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            int i = intList[0];
            System.Console.WriteLine(i);
            System.Console.WriteLine(personer.Count);


            //Exercise modul 2 exercise List<T> right?

            System.Console.WriteLine("this is the countperson:\n");


            System.Console.WriteLine(prog.countPersons("andres"));


            prog.MakeNamesGemen();
            System.Console.WriteLine("///////////////////////////////////////");
            prog.MakeNamesVersal();
            System.Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            prog.MakenNamesPascalCase();
            System.Threading.Thread.Sleep(2500);
            Dictionary<string, double> fruits = new Dictionary<string, double>();
            fruits.Add("Apple", 9.99);
            fruits["Orange"] = 12.90;
            System.Console.WriteLine(fruits["Apple"]);
            foreach (object fruit in fruits)
            {
                System.Console.WriteLine(fruit);
            }

            Queue<DateTime> dates = new Queue<DateTime>();
            dates.Enqueue(DateTime.Now);
            dates.Enqueue(new DateTime(2009, 03, 04));
            foreach (DateTime date in dates) // ingen unboxing
            { System.Console.WriteLine(date); } // Anropar toString

            Stack<object> objStack = new Stack<object>();
            objStack.Push("Hello");
            objStack.Push("World");
            System.Console.WriteLine(objStack.Pop());
            System.Console.WriteLine(objStack.Pop());

        }

        // Method CountPersons or characters
        public int countPersons(string name)
        {
            int count = 0;
            for (int aha = 0; aha < names.Count; aha++)
            {
                if (names[aha] == name || names[aha].ToLower().Contains(name))
                {
                    count++;
                }
                System.Console.WriteLine(names[aha]);
            }
            System.Console.WriteLine("------------------------------------------");
            return count;
        }

        // Method MakeNamesGemen
        public void MakeNamesGemen()
        {

            for (int a = 0; a < names.Count; a++)
            {
                System.Console.WriteLine(names[a].ToLower());
            }

        }
        // Method MakeNamesVersal
        public void MakeNamesVersal()
        {

            for (int a = 0; a < names.Count; a++)
            {
                System.Console.WriteLine(names[a].ToUpper());
            }

        }
        // Method MakenNamesPascalCase
        public void MakenNamesPascalCase()
        {

            for (int a = 0; a < names.Count; a++)
            {
                System.Console.WriteLine(names[a].Substring(0, 1).ToUpper() + names[a].Substring(1).ToLower());
            }

        }

    }
}