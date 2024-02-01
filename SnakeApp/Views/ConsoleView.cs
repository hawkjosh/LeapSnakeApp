using SnakeApp.Models;

namespace SnakeApp.Views
{
    public class ConsoleView  // This handles all the console output, like drawing the game board, snake, and food
    {
        public ConsoleView() // Constructor: initialize console window settings
        {
            Console.Title = "Snake Game"; // Set the title of the console window
            Console.WindowHeight = 16; // Set the height of the console window
            Console.WindowWidth = 32; // Set the width of the console window
            Console.BufferHeight = 16; // Set the height of the buffer
            Console.BufferWidth = 32; // Set the width of the buffer
            Console.BackgroundColor = ConsoleColor.White; // Set the background color of the console window
            Console.Clear(); // Clear the console window
            Console.ForegroundColor = ConsoleColor.Black; // Set the foreground color of the console window
            Console.CursorVisible = false; // Hide the cursor
        }

        public void Render(Game game)
        {
            DrawBoardBorder();
            DrawSnake(game.Snake);
            DrawFood(game.Food);

            throw new NotImplementedException();
            // Implement code to draw the game state on the console
        }

        // TODO: Figure out what property will be used to determine the board width and height, use as param for DrawBoardBoarder, currently using full width and height of console window
        private void DrawBoardBorder() // Method to draw border around game board
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
            }

            // Draw the side borders
            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < Console.WindowHeight - 1; i++)
            {
                Console.Write("#" + new string(' ', Console.WindowWidth - 3) + "#");
            }

            // Draw the bottom border
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
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
    }
}
