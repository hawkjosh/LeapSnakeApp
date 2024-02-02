using SnakeApp.Models;

namespace SnakeApp.Views
{
    public class ConsoleView  // This handles all the console output, like drawing the game board, snake, and food
    {
        public void Render(Game game, Food food)
        {
            Console.SetCursorPosition(food.GetCurrentPosition().X, food.GetCurrentPosition().Y);
            Console.Write("X");
        
        }

    }
}
