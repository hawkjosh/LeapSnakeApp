

using SnakeApp.Models;

namespace SnakeApp.Controllers
{
    public class GameController  // This manages and controls the game flow, handling user inputs, and updating the model
    {
        int speedInput;
        private string? input;
        char[] DirectionChars = ['^', 'v', '<', '>'];
        Game game;
        Direction? direction = null;
        private int gameWidth;
        private int gameHeight;
        private Coordinate? foodCoordinate;
        public GameState GameState { get; private set; }
        Tile[,] map;
        string speedInputQuestion = "Please enter your desired speed (1-->Low, 2-->Medium, 3-->High";
        public void Start()
        {
            // Implement the game loop here: process input, update game state, render view, etc.
            InitGame();
            
            while (true)
            {
                if(GameState == GameState.InProgress)
                {
                    StartSnakeGame();
                }
                if(GameState == GameState.EndGame)
                {
                    Console.WriteLine("Game Over!");
                    break;
                }

            }
        }

        private void StartSnakeGame()
        {
            
            while(!direction.HasValue && GameState == GameState.InProgress)
            {
                GetDirection();
            }
            while(GameState == GameState.InProgress)
            {
                if (Console.WindowWidth != gameWidth || Console.WindowHeight != gameHeight)
                {
                    Console.Clear();
                    Console.WriteLine("Console was resized. Game Over!");
                    GameState = GameState.EndGame;
                    break;
                }
                var currentPosition = game.Snake.GetCurrentPosition();
                UpdateSnakePosition(currentPosition);
                if (!CheckIfPositionIsValid(currentPosition))
                {
                    break;
                }

                //Set Cursor position
                Console.Write(DirectionChars[(int)direction!]);

                //Save snake's position
                game.Snake.SnakeQueue.Enqueue(currentPosition);

                
                if (map[currentPosition.X, currentPosition.Y] == Tile.Food)
                {
                    //If snake eats food successfully, update food position
                    foodCoordinate = game.Food.UpdateFoodPosition();
                }
                else
                {

                }
                
            }
        }

        private bool CheckIfPositionIsValid(Coordinate currentPosition)
        {
            if(currentPosition.X < 0 || currentPosition.Y < 0 ||
                currentPosition.X >= game.Board.Coordinates.X ||
                currentPosition.Y >= game.Board.Coordinates.Y ||
                map[currentPosition.X,currentPosition.Y] is Tile.Snake) {
                Console.Clear();
                Console.WriteLine($"Game Over!! Your score is {game.Snake.SnakeLength}");
                GameState = GameState.EndGame;
                return false;
            }
            return true;
        }

        private void UpdateSnakePosition(Coordinate currentPosition)
        {
            switch (direction)
            {
                case Direction.Left:
                    currentPosition.X--; break;
                case Direction.Right:
                    currentPosition.X++; break;
                case Direction.Up:
                    currentPosition.Y--; break;
                case Direction.Down:
                    currentPosition.Y++; break;
            }            
        }

        private void GetDirection()
        {
            //Takes direction from user

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    direction = Direction.Up; break;
                case ConsoleKey.DownArrow:
                    direction = Direction.Down; break;
                case ConsoleKey.LeftArrow:
                    direction = Direction.Left; break;
                case ConsoleKey.RightArrow:
                    direction = Direction.Right; break;
                case ConsoleKey.Escape:
                    GameState = GameState.EndGame; break;
            }
        }

        private void InitGame()
        {
            //Welcome Message
            Console.WriteLine("Welcome to the Game of Snake!");

            //Get user speed
            GameState = GameState.WaitingForUserInput;
            Console.WriteLine(speedInputQuestion);
            GetUserSpeed();
            foodCoordinate = game.Food.GetCurrentPosition();
            game = new Game(speedInput); //Gmae model constructs the Snake, Food and Board objects
            UpdateConsoleDimensions();
            GameState = GameState.InProgress;
        }

        private void UpdateConsoleDimensions()
        {
            gameWidth = game.Board.Coordinates.X;
            gameHeight = game.Board.Coordinates.Y;
            map = new Tile[gameWidth, gameHeight];
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

        public GameController()
        {
            GameState = GameState.WaitingToStart;
        }
    }
}
