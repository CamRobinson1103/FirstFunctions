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


                {
                    Console.Clear();
                    Console.WriteLine("Welcome to my domain... Enter your name.");
                    _playerName = Console.ReadLine();
                    Console.WriteLine("Are you sure you want the name " + _playerName + "?");
                    input = GetInput("Yes", "No", "Are you sure you want the name " + _playerName + "?");
                    if (input == '1')
                    {
                        return;
                    }
                    else if (input == '2')
                    {
                        Console.WriteLine("Yo, that name TRASH! Try again.");
                        RequestName(ref _playerName);
                    }
                }
            }
        }




        void Explore()
        {
            string petName = "doggo";
            char input = ' ';
            input = GetInput("Go Left", "Go right", "You came to a cross road");
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
            int characterHealth = 12;
            _gameOver = StartBattle(ref characterHealth, character2Health);

        }

        void EnterRoom(int roomNumber)
        {
            string exitMessage = "";
            switch (1+1)
            {
                case 0:
                    exitMessage = "You left that place because it looked terrible.";
                    Console.WriteLine("Before you stand a phat a$$ castle.");
                    break;

                case 1:
                case 2:
                    exitMessage = "You left the kitchen. It smelled.";
                    Console.WriteLine("You enter the castle's kitchen. There's knCamives on the ground, rats everywhere, and moldy chicken.");
                    break;

                default:
                    exitMessage = "You left the hallway... It was so hypnotic you thought you'd throw up.";
                    Console.WriteLine("You enter a hallway that seems to never end.");


            }
            if (roomNumber == 0)
            {
                Console.WriteLine();
                
            }
            else if (roomNumber == 1)
            {
               
            }
            else if (roomNumber >= 2)
            {
               
            }
            Console.WriteLine("You are in room " + roomNumber);
            char input = ' ';
            input = GetInput("Go forward", "Go back", "Which direction would you like to go?");
            if (input == '1')
            {
                EnterRoom(roomNumber + 1);
            }
            Console.WriteLine("You are leaving room " + roomNumber);
        }

        //Battlin Doods
        bool StartBattle(ref int characterHealth, int character2Health)
        {
            char input = ' ';
            while (characterHealth > 0 && character2Health > 0)
            {
                Console.WriteLine("Charactrt 1 Health: " + characterHealth);
                Console.WriteLine("Character 2 Health " + character2Health);
                input = GetInput("Attack", "Defend", "What will you do?");
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
                Console.Clear();
                //Slime: The Second Coming
                Console.WriteLine("As you continue your quest to Portlad, a syndicate of slime ambush you to avenge their fallen brother!");
                int character3Health = 5;
                int character4Health = 5;
                int character5Health = 5;
                _gameOver = StartBattle(ref characterHealth, character3Health);
                _gameOver = StartBattle(ref character4Health, character5Health);
                while (characterHealth > 0 && character3Health > 0 && character4Health > 0 && character5Health > 0) ;
                {
                    Console.WriteLine("Charactrt 1 Health: " + characterHealth);
                    Console.WriteLine("Charactrt 3 Health: " + character3Health);
                    Console.WriteLine("Charactrt 4 Health: " + character4Health);
                    Console.WriteLine("Charactrt 5 Health: " + character5Health);
                    input = GetInput("Attack", "Defend", "What will you do?");
                }




            }
            return characterHealth <= 0;

        }



        void ViewStats()
        {
            Console.WriteLine(_playerName);
            Console.WriteLine("\nPress any key to continue");
            Console.Write("> ");
            Console.ReadKey();
        }

        public char GetInput(string option1, string option2, string query)
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
            EnterRoom(0);
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThanks for the $60, LOSER!!!");
            //yuh boi
        }
    }
}
