using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Print welcome message and ask for Username
            //printing Welcome message
            Console.WriteLine("====================================");
            Console.WriteLine("WELCOME TO THE FISHING GAME");
            Console.WriteLine("BY: FRED");
            Console.WriteLine("====================================");

            //ask user for their username
            Console.WriteLine("What is your Username?");

            //making a variable userInput and capturing the data from the user
            string userInput = Console.ReadLine();

            //Print out the user name
            Console.WriteLine("Hello:" + userInput);

            #endregion

            #region Create Player object and set score to 0
            //created a new instance of Player and set the Username and print out
            Player player1 = new Player();
            player1.Username = userInput;
            player1.Score = 0;

            Console.WriteLine("player1 Username:" + player1.Username);
            Console.WriteLine("player1 Score:" + player1.Score);

            #endregion


            GameEngine game = new GameEngine();
            

            Fish fish1 = game.CatchFish();

            Console.WriteLine("fish1 FishType:" + fish1.FishType);
            Console.WriteLine("fish1 Points:" + fish1.Points);

            //add fish points to Player Score
            player1.Score = player1.Score + fish1.Points;
            Console.WriteLine("player1 Score:" + player1.Score);

            

            //GameEngine game2 = new GameEngine();
            Fish fish2 = game.CatchFish();

            Console.WriteLine("fish2 FishType:" + fish2.FishType);
            Console.WriteLine("fish2 Points:" + fish2.Points);



            //add fish points to Player Score
            player1.Score = player1.Score + fish2.Points;
            Console.WriteLine("player1 Score:" + player1.Score);


        }
    }
}
