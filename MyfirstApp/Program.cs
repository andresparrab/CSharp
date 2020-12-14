using System;

namespace MyfirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Numbers

            // Console.WriteLine("Hello wolrd");

            // // byte MaxValue = 255;
            // byte byteValue = 200;
            // Console.WriteLine(byteValue);

            // // Int MaxValue = 2147483647
            // int intValue = 201;

            // // Lon MaxValue = 9223372036854775807;
            // long lonValue = 3000;

            // // Even if the value of intValue fits in the byteValue. less than 255. the computer dont know and we have to tell it with (byte)
            // byteValue = (byte)intValue; // Explicit typkonvertering

            // intValue = byteValue; //Implicit typkonvertering (automatisk)

            // float floatValue = 45.45454f;  // need to have f at the end

            // double doubleValue = 45.454545; // No need for f in the end (Newway)

            // intValue = (int)doubleValue;
            // System.Console.WriteLine(intValue);
            // //Console.ReadLine();



            #endregion
            #region Chars
            //  char bokstav = 'A';  // this is in ascii code char(65)
            //     char number = (char)49; // this will print out 1, because the ascii code for 1 is 49
            //     System.Console.WriteLine(bokstav);
            //     Console.WriteLine(number);

            //     string helloPhrase = "Hello " + "Freddie";
            //     string helloAgain = string.Format("hello {0} i am the letter {1}", bokstav, number);
            //     System.Console.WriteLine(helloPhrase);
            //     System.Console.WriteLine(helloAgain);
            #endregion

            #region ConditionalStatementsIF
            // System.Console.WriteLine("Please enter a temperature: ");
            // int temperature = int.Parse(Console.ReadLine());
            // if (temperature >= 20)
            // {
            //     System.Console.WriteLine("It is warm today");
            //     System.Console.WriteLine("I will go and buy ice crea...");
            // }
            // else if (temperature > 0)
            // {
            //     System.Console.WriteLine("Is higher than 0 degress");
            // }

            // else
            // {
            //     System.Console.WriteLine("It is freezing outside");
            //     System.Console.WriteLine("I have to buy a jacket!!");
            // }

            // Console.WriteLine("the temperature is {temperature}", temperature);

            #endregion
            #region ConditionalStatments_Switch
            //    System.Console.WriteLine("type in a number: ");
            //     int tal;
            //     tal = int.Parse(Console.ReadLine());
            //     System.Console.WriteLine(value: "this is the number you typed: " + tal);
            //     switch (tal)
            //     {
            //             case 1:
            //                 System.Console.WriteLine("Du skrev 1.");
            //                 break;
            //             case 2:
            //                 System.Console.WriteLine("Du skrev 2.");
            //                 break;
            //             case 3:
            //                 System.Console.WriteLine("Du skrev 3.");
            //                 break;
            //             default:
            //                 System.Console.WriteLine("Varken 1,2, eller 3");
            //                 break;
            //     }

            #endregion

            #region test debugger
            // var name = "";
            // System.Console.WriteLine("Enter a name: ");
            // name = Console.ReadLine();
            // Console.WriteLine("hello: " + name);
            #endregion

            #region loops
            // int startValue = 1;
            // while (startValue < 10)
            // {
            //     System.Console.WriteLine("Varv som karusellen har åkt : " + startValue);
            //     startValue += 1;
            // }
            #endregion

            int[] mineNumbers = new int[10];
            System.Console.WriteLine("this is the arra: " + mineNumbers.Length);



        }
    }
}
