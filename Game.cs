using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace HelloWorld
{

    class Game
    {
        //Ends the game when true
        private bool _gameOver = false;
        string playerName = "none";
        int playerHealth;
        int playerAttack;
        string playerRole;
        int gameState;
        char input;
        public void OpenMainMenu()
        {

            while (input != '1')
            {
                Console.Clear();
                Console.WriteLine("Welcome! Please Enter your name");
                playerName = Console.ReadLine();
                Console.WriteLine("Are you sure you want the name " + playerName + "?");
                input = getInput("Yes", "No");
                if (input == '2')
                {
                    Console.WriteLine("Yo, that name TRASH! Try again.");
                }
            }
        }
        public char getInput(string option1, string option2)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine("[1] " + option1);
                Console.WriteLine("[2] " + option2);
                Console.WriteLine("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            return input;
        }
        //Run the game
        public void Run()
        {
            //Perform initialization tasks
            Start();
            //Loop update routine until the game is over
            while (!_gameOver)
            {
                Update();
            }
            //Perform cleanup tasks
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            gameState = 0;
            input = ' ';
            playerName = "Hero";
            playerHealth = 100;
            playerAttack = 20;
            playerRole = "none";
        }

        //Repeated until the game ends
        public void Update()
        {
            //switch (gameState)
            //{
            //    case 0:
            //        {
            //            OpenMainMenu();
            //            break;
            //        }
            //}
            OpenMainMenu();
        }

        //Performed once when the game ends
        public void End()
        {

        }
    }
}
