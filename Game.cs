using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {

        bool _gameOver = false;
        //Run the game
        public void Run()
        {
            Start();

            while(_gameOver == false)
            {
                Update();
            }
            End();
        }
        //Performed once when the game begins
        //Use for initializing variables
        //Also used for performing start up tasks that should only be done once
        public void Start()
        {
            Console.WriteLine("Welcome to my domain...");
        }

        //Repeated until the game ends
        //Used for all game logic that will repeat
        public void Update()
        {
            char input = ' ';
            Console.Clear();
            Console.WriteLine("\nTestin stuff");
            Console.WriteLine("> ");
            input = Console.ReadKey().KeyChar;
            if(input == 'q')
            {
                _gameOver = true;
            }
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThanks for your money, LOSER!!!");
        }
    }
}
