namespace SnakeApp.Models
{
    public class Game  // This manages the state of the game
    {
        public Snake Snake { get; private set; }
        public Food Food { get; private set; }
        public Board Board { get; private set; }

        public Game()
        {
            int userInputSpeed = 1;
            //Setting default speed
            Snake = new Snake(userInputSpeed);
            
            Board = new Board();
            CalculateNexFoodPosition();
            Board.PrintBoard(Food);
        }

        // Add methods for game logic such as starting, updating state, checking for game over, etc.
        private void CalculateNexFoodPosition()
        {
            var emptyPositions = Board.GetAllEmptyPositions();
            int index = Random.Shared.Next(emptyPositions.Count);
            (int x, int y) = emptyPositions[index];
            if (Food == null)
            {
                Food = new Food(x, y);
            }
            else
            {
                Food.RenewFood(x, y);

            }
            Board.SetFoodInBoard(x, y);
            // Calculates x and y within the board and excluding snake position queue and assign them to Food.
        }
    }   
}
