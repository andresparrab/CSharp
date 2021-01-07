using System;
using System.Collections.Generic;

namespace DartApp
{
    class Player
    {
        public string name { get; set; }
        // public List<int> turns { get; set; }
        public List<int> turns = new List<int>();
        public void CalculatePoints()
        {

        }
        public void Add_turn()
        {

        }
    }
    class Game
    {
        public List<Player> newPlayers = new List<Player>();
        public Game()
        {

        }

        public void AddPlayer(string name)
        {
            Player current = new Player();
            current.name = name;
            newPlayers.Add(current);
            // System.Console.WriteLine(current.name);
        }
        public void PlayGame()
        {
            System.Console.WriteLine("Welcome to the awsome Dart game");

        }
        public void prinplayers()
        {
            foreach (Player tname in newPlayers)
                System.Console.WriteLine(" the players are -------------->>>>>>>>>>>> : {0}", tname.name);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Game My_game = new Game();
            My_game.PlayGame();
            Player player1 = new Player();
            player1.name = "Andres";
            System.Console.WriteLine(player1.name);
            player1.turns.Add(1);
            player1.turns.Add(2);
            player1.turns.Add(3);
            player1.turns.Add(4);
            int sum = 0;
            for (int a = 0; a < player1.turns.Count; a++)
            {
                sum += player1.turns[a];
                System.Console.WriteLine(player1.turns[a]);
            }
            System.Console.WriteLine("the sum is : {0}", sum);
            //string playerName = Console.ReadLine();
            My_game.AddPlayer(Console.ReadLine());
            My_game.AddPlayer(Console.ReadLine());
            My_game.AddPlayer(Console.ReadLine());
            My_game.AddPlayer(Console.ReadLine());
            // System.Console.WriteLine("the playername is {0}:::: ", playerName);
            My_game.prinplayers();
        }
    }
}
