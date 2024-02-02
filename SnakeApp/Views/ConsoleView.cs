﻿using SnakeApp.Models;

namespace SnakeApp.Views
{
    public class ConsoleView  // This handles all the console output, like drawing the game board, snake, and food
    {
        //Board board = new Board(Console.WindowWidth, Console.WindowHeight); // TEMPORARY FOR TESTING

        public ConsoleView() // Constructor: initialize console window settings
        {
            Console.Title = "Snake Game"; // Set the title of the console window
            //Console.WindowHeight = 16; // Set the height of the console window
            //Console.WindowWidth = 32; // Set the width of the console window
            //Console.BufferHeight = 16; // Set the height of the buffer
            //Console.BufferWidth = 32; // Set the width of the buffer
            //Console.BackgroundColor = ConsoleColor.White; // Set the background color of the console window
            Console.Clear(); // Clear the console window
            //Console.ForegroundColor = ConsoleColor.Black; // Set the foreground color of the console window
            Console.CursorVisible = false; // Hide the cursor
        }

        public void Render(Game game)
        {
            //DrawBorder(game.Board); // This error should go away when the board is given parameters in the Game class
            //DrawBorder(); // TEMPORARY FOR TESTING
            
            DrawBorder(game.Board);
            DrawSnake(game.Snake);
            DrawFood(game.Food);
        }

        // TODO: Figure out what property will be used to determine the board width and height, use as param for DrawBoardBoarder, currently using full width and height of console window
        private void DrawBorder(Board board) // Method to draw border around game board
        //private void DrawBorder() // TEMPORARY FOR TESTING...also need to change each game.Board reference below to board
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("SNAKE GAME - Score: 0");

            Console.SetCursorPosition(0, 1);
            for (int x = 0; x < board.width; x++) // Top border
            {
                if (x % 2 == 0)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }

            Console.SetCursorPosition(0, 2);
            for (int y = 0; y < board.height - 2; y++) // Left and right borders
            {
                Console.Write("#");
                for (int x = 0; x < board.width - 2; x++)
                    Console.Write(" ");
                Console.Write("#");
                Console.SetCursorPosition(0, y + 2);
            }

            Console.SetCursorPosition(0, board.height - 1);
            for (int x = 0; x < board.width; x++) // Bottom border
            {
                if (x % 2 == 0)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }

        public void DrawSnake(Snake snake) // Method to draw the Snake
        {
            // Logic to draw the snake here
            var snakePosition = snake.GetCurrentPosition();
            Console.SetCursorPosition(snakePosition.X, snakePosition.Y);
            //Console.Write("*");
            if (snake.SnakeQueue.Count > 0)
            {
                foreach (var position in snake.SnakeQueue)
                {
                    Console.SetCursorPosition(position.X, position.Y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("*");
                    var cursorPos2 = Console.GetCursorPosition();
                    
                }
            }
            
        }

        public void DrawFood(Food food) // Method to draw the food
        {
            // Logic to draw the food here
            var foodPosition = food.GetCurrentPosition();
            Console.SetCursorPosition(foodPosition.X, foodPosition.Y);
            food.SetFoodInBoard(foodPosition.X, foodPosition.Y);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("F");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            
        }

        //// TEMPORARY FOR TESTING
        //public static void Main(string[] args)
        //{
        //    ConsoleView consoleView = new ConsoleView();
        //    consoleView.Render(); // Call the Render method for testing

        //    Console.ReadKey(); // Wait for user input before closing the console window
        //}
    }
}
