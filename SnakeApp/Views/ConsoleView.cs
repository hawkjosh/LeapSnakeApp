using SnakeApp.Models;

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
            DrawBorder(game.Board); // This error should go away when the board is given parameters in the Game class
            //DrawBorder(); // TEMPORARY FOR TESTING
            DrawSnake(game.Snake);
            DrawFood(game.Food);
        }

        // TODO: Figure out what property will be used to determine the board width and height, use as param for DrawBoardBoarder, currently using full width and height of console window
        private void DrawBorder(Game game) // Method to draw border around game board
        //private void DrawBorder() // TEMPORARY FOR TESTING...also need to change each game.Board reference below to board
        {
            Console.SetCursorPosition(1, 1);
            for (int x = 0; x < game.Board.Width - 1; x++) // Top border
            {
                if (x % 2 == 0)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }

            Console.SetCursorPosition(1, 2);
            for (int y = 0; y < game.Board.Height - 2; y++) // Left and right borders
            {
                Console.Write("#");
                for (int x = 0; x < game.Board.Width - 3; x++)
                    Console.Write(" ");
                Console.Write("#");
                Console.SetCursorPosition(1, y + 2);
            }

            Console.SetCursorPosition(1, game.Board.Height - 1);
            for (int x = 0; x < game.Board.Width - 1; x++) // Bottom border
            {
                if (x % 2 == 0)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
        }

        private void DrawSnake(Snake snake) // Method to draw the Snake
        {
            // Logic to draw the snake here
        }

        private void DrawFood(Food food) // Method to draw the food
        {
            // Logic to draw the food here
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
