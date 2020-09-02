using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace HelloWorld
{

    class Game
    {
        //Ends the game when true
        bool _gameOver = false;
        string _playerName = "";
        int characterHealth;
        int playerHit;
        string playerColor;
        int gameState;
        char input;
       void RequestName(ref string petName)
        {
            {

                while (input != '1')
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to my domain... Enter your name.");
                    _playerName = Console.ReadLine();
                    Console.WriteLine("Are you sure you want the name " + _playerName + "?");
                    input = getInput("Yes", "No", "Are you sure you want the name " + _playerName + "?");
                    if (input == '2')
                    {
                        Console.WriteLine("Yo, that name TRASH! Try again.");
                    }
                }
            }
        }




        void Explore()
        {
            string petName = "doggo";
            char input = ' ';
            input = getInput("Go Left", "Go right", "You came to a cross road");
            if (input == '1')
            {
                Console.WriteLine("A group of bandits appered! IT'S AN AMBUSH and they want all ya moola!" + "There is a " + petName + " out and slices the bandit with the dagger in its mouth. They are ded." + " It seems like the doggo wants to join you on your quest. What do you want to name it?");
                RequestName(ref petName);
                petName = Console.ReadLine();
                Console.WriteLine("Its new name is " + petName);
                Console.ReadKey();
            }
            else if (input == '2')
            {
                Console.WriteLine("You continue your journey and head towards Portlad");
                Console.ReadKey();
            }
            
            Console.WriteLine("A wild suraimu appeared!");
            int character2Health = 5;
            int characterHealth =12 ;
            _gameOver = StartBattle(ref characterHealth, character2Health);

        }
        //Battlin Doods
        bool StartBattle(ref int characterHealth, int character2Health)
        {
            char input = ' ';
            while (characterHealth > 0 && character2Health > 0)
            {
                Console.WriteLine("Charactrt 1 Health: " + characterHealth);
                Console.WriteLine("Character 2 Health " + character2Health);
                input = getInput("Attack", "Defend", "What will you do?");
                if (input == '1')
                {
                    character2Health -= 7;
                    Console.WriteLine("You did 3 damage to the enemy");
                    character2Health -= 4;
                }
                else if (input == '2')
                {
                    Console.WriteLine("You blocked the enemies attack");
                    Console.ReadKey();
                    continue;
                }
                characterHealth -= 12;
                Console.WriteLine("The suraimu did 1 damage to you");
                Console.ReadKey();
            }
            return characterHealth <= 0;
            Console.Clear();

            Console.WriteLine("As you continue your quest to Portlad, a syndicate of slime appear before you to avenge their fallen brother!");
            int character3Health = 5;
            int character4Health = 5;
            int character5Health = 5;
            _gameOver = StartBattle(ref characterHealth, character3Health);
            _gameOver = StartBattle(ref character4Health, character5Health);
        }

        void ViewStats()
        {
            Console.WriteLine(_playerName);
            Console.WriteLine("\nPress any key to continue");
            Console.Write("> ");
            Console.ReadKey();
        }

        public char getInput(string option1, string option2, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine("[1] " + option1);
                Console.WriteLine("[2] " + option2);
                Console.WriteLine("Press 3 to view stats");
                Console.WriteLine("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input == '3')
                {
                    ViewStats();
                }
            }
            return input;
        }
        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("Welcome to my domain...");
            gameState = 0;
            input = ' ';
            _playerName = "Hero";
            characterHealth = 12;
            playerHit = 5;
            playerColor = "Rainbow";
        }

        //Repeated until the game ends
        public void Update()
        {
            RequestName(ref _playerName);
            Explore();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThanks for the $60, LOSER!!!");
        }
    }
}
