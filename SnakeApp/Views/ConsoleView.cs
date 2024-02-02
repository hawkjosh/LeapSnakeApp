using SnakeApp.Models;

namespace SnakeApp.Views
{
    public class ConsoleView  // This handles all the console output, like drawing the game board, snake, and food
    {
        public ConsoleView() // Constructor: initialize console window settings
        {
            Console.Title = "Snake Game"; // Set the title of the console window
            Console.Clear(); // Clear the console window
            Console.CursorVisible = false; // Hide the cursor
        }

        public void Render(Game game)
        {
            DrawBorder(game.Board);
            DrawSnake(game.Snake);
            DrawFood(game.Food);
        }

        private void DrawBorder(Board board) // Method to draw border around game board
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
            var snakePosition = snake.GetCurrentPosition();
            Console.SetCursorPosition(snakePosition.X, snakePosition.Y);
            if (snake.SnakeQueue.Count > 0)
            {
                foreach (var position in snake.SnakeQueue)
                {
                    Console.SetCursorPosition(position.X, position.Y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("S");
                }
            }
            
        }

        public void DrawFood(Food food) // Method to draw the food
        {
            var foodPosition = food.GetCurrentPosition();
            Console.SetCursorPosition(foodPosition.X, foodPosition.Y);
            food.SetFoodInBoard(foodPosition.X, foodPosition.Y);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("F");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            
        }

    }
}
