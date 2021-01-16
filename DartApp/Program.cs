using System;
using System.Collections.Generic;

namespace DartApp
{
    static class DartBoard
    {
        private static int[] dartBoard = { 20, 1, 18, 4, 13, 6, 10, 15, 2, 17, 3, 19, 7, 16, 8, 11, 14, 9, 12, 5 };
        // throw random
        public static int aim()
        {
            Random randomizer = new Random();
            int number = randomizer.Next(1, 21);
            return aim(number);
        }
        // Aim at an specific number
        public static int aim(int number)
        {
            Random randomizer = new Random();
            int[] ProbabilitiesValues = { 5, 15, 60 };
            int myProbability = ProbabilitiesValues[randomizer.Next(0, ProbabilitiesValues.Length)];
            int[] positiveNegative = { -1, 1 };
            int previousOrNext = positiveNegative[randomizer.Next(0, positiveNegative.Length)];
            int hitNumber = number;
            
            // base on the probability get the new number
            if (myProbability == 60)
            {

                System.Console.WriteLine("Aimend number {0} probability : {1}, you hit the number", hitNumber, myProbability);
                
            }
            else if (myProbability == 15)
            {
                int indexOfNumber = Array.IndexOf(dartBoard, number);

                if (number == 20)
                {
                    hitNumber = dartBoard[indexOfNumber + 1];
                }
                else if (number == 5)
                {
                    int[] SecondlastAndBegining = { dartBoard.Length - 2, 0 };
                    previousOrNext = SecondlastAndBegining[randomizer.Next(0, SecondlastAndBegining.Length)];
                    System.Console.WriteLine("Thi is the value of previousNext {0}", previousOrNext);
                    System.Console.WriteLine("This is when is 5: {0}", dartBoard[previousOrNext]);
                    hitNumber = dartBoard[indexOfNumber - 1];
                }
                else
                {
                    hitNumber = dartBoard[indexOfNumber + previousOrNext];
                }

                System.Console.WriteLine("Aimend number {0} probability : {1}, number hit is {2}", number, myProbability, hitNumber);
                return hitNumber;
            }
            else if (myProbability == 5)
            {
                int randomIndex = randomizer.Next(0, dartBoard.Length);
                string[] posibleValues = { randomIndex.ToString(), "out" };
                string inOrOut = posibleValues[randomizer.Next(0, posibleValues.Length)];
                if (inOrOut != "out")
                {
                    hitNumber = dartBoard[randomIndex];
                    System.Console.WriteLine("Aimend number {0} probability : {1} you hit the numbner {2}", number, myProbability, hitNumber);
                    return hitNumber;
                }
                else
                {
                    System.Console.WriteLine("Aimend number {0} probability : {1} you hit OUTSIDE THE BOARD!!", number, myProbability);
                    return 0;
                }


            }
            return hitNumber;
        }
        public static void printBoard()
        {
            System.Console.WriteLine(string.Join("|", dartBoard));
        }

    }
    class Player
    {
        public string name { get; set; }
        private List<int[]> scoresPerTurn = new List<int[]>();

        private List<Turns> turns = new List<Turns>();

        public void Add_turn(int first, int second, int third)
        {
            // Add new turn to the list

            Turns newTurns = new Turns();
            newTurns.first = first;
            newTurns.second = second;
            newTurns.third = third;
            turns.Add(newTurns);
            System.Console.WriteLine("New turns added {0},{1},{2} :::", newTurns.first, newTurns.second, newTurns.third);

        }

        public void removeTurn()
        {
            turns.RemoveAt(turns.Count - 1);
        }
        public void clearTurns()
        {
            turns.Clear();
        }
        public int CalculatePoints()
        {
            // Calculate turns
            int totalPoints = 0;
            
            foreach (Turns current in turns)
                totalPoints += current.Get_score();
            return totalPoints;
        }
        public void Print_turns()
        {

            int[] turSet = new int[3];
            foreach (Turns current in turns)
            {
                turSet[0] = current.first;
                turSet[1] = current.second;
                turSet[2] = current.third;
                scoresPerTurn.Add(turSet);
                System.Console.WriteLine("|{0}|", string.Join(",", turSet));
            }

        }
    }

    class Turns
    {

        public int first { get; set; }
        public int second { get; set; }
        public int third { get; set; }
        public int Get_score()
        {
            int turn_points = first + second + third;
            return turn_points;
        }
    }
    class Game
    {
        private List<Player> newPlayers = new List<Player>();

        public void AddPlayer(string name)
        {
            Player current = new Player();
            current.name = name;
            newPlayers.Add(current);
            // System.Console.WriteLine(current.name);
        }
        public void PlayGame()
        {
            int choice;
            System.Console.WriteLine("Welcome to the awsome Dart game");
            // The menu:
            do
            {
                System.Console.WriteLine("1. Add new player");
                System.Console.WriteLine("2. Start the game");
                System.Console.WriteLine("3. Quit Game");
                System.Console.WriteLine("Please enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("Please Enter the player name: ");
                        AddPlayer(Console.ReadLine());
                        break;
                    case 2:
                        startGame();
                        break;
                    case 3:
                        System.Console.WriteLine("exiting ....");
                        break;
                    default:
                        System.Console.WriteLine(" Please enter a valid choice");
                        break;
                }
            } while (choice != 3);

        }

        private void startGame()
        {
            int[] throws = new int[3];
            string newThrow = "";
            DartBoard.printBoard();
            int counter = 0;
            do
            {

                for (int i = 0; i < newPlayers.Count; i++)
                {

                    System.Console.WriteLine("Current player -----{0}----- ", newPlayers[i].name.ToUpper());
                   
                    for( int j=0; j < 3; j++)
                    {
                         newThrow = Console.ReadLine();
                    if (newThrow != "")
                    {
                        while(newThrow != "")
                        {
                            throws[j] = DartBoard.aim(int.Parse(newThrow));
                            break;

                        }
                    }
                    else
                    {
                         while (newThrow =="")
                        {
                            throws[j] = DartBoard.aim();
                            break;                          
                        }                                               
                    }
                    }
               
                    newPlayers[i].Add_turn(throws[0], throws[1], throws[2]);
                            counter = newPlayers[i].CalculatePoints();
                           
                    if (counter == 101)
                    {
                        System.Console.WriteLine("********* {0} win with {1} points *******", newPlayers[i].name, counter);
                        newPlayers[i].Print_turns();
                        newPlayers[i].clearTurns();
                        break;
                    }
                    else if (counter > 101)
                    {
                        newPlayers[i].removeTurn();
                        counter = newPlayers[i].CalculatePoints();
                        // newPlayers[i].Print_turns();
                    }
                     System.Console.WriteLine("Total points: {0} ", counter);
                }
            }
            while (counter < 101);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game My_New_Game = new Game();
            My_New_Game.PlayGame();
        }
    }
}
