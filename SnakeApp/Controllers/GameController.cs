

using SnakeApp.Models;

namespace SnakeApp.Controllers
{
    public class GameController  // This manages and controls the game flow, handling user inputs, and updating the model
    {
        int speedInput;
        private string? input;
        string speedInputQuestion = "Please enter your desired speed (1-->Low, 2-->Medium, 3-->High";
        public void Start()
        {
            // Implement the game loop here: process input, update game state, render view, etc.
            InitGame();
        }

        private void InitGame()
        {
            Console.WriteLine("Welcome to the Game of Snake!");
            Console.WriteLine(speedInputQuestion);
            GetUserSpeed();
            Game game = new Game(speedInput);
        }

        private void GetUserSpeed()
        {
            while (!int.TryParse(input = Console.ReadLine(), out speedInput) || speedInput < 1 || speedInput > 3)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    speedInput = 1;
                    break;
                } else
                {
                    Console.WriteLine("Invalid input, please try again...");
                    Console.Write(speedInputQuestion);
                }
            }
        }
    }
}
