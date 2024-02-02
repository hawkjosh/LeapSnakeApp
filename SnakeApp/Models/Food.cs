using SnakeApp.Interfaces;

namespace SnakeApp.Models
{
    public class Food : ICurrentPosition  // This manages the position and type of food items on the board
    {
        // TODO: Add properties and methods
        private Coordinate foodCoordinate;
        private Board board;


        public Coordinate GetCurrentPosition()
        {
            return foodCoordinate;
        }

  
        public List<(int X, int Y)> GetAllEmptyPositions()
        {
            List<(int X, int Y)> emptyPossitions = new();
            for (int i = 2; i < board.width - 3; i++)
            {
                for (int j = 3; j < board.height - 4; j++)
                {
                    if (board.map[i, j] is Tile.Empty)
                    {
                        emptyPossitions.Add((i, j));
                    }
                }
            }
            return emptyPossitions;
        }

        public void SetFoodInBoard(int x, int y)
        {
            board.map[x, y] = Tile.Food;
        }


        public Coordinate CalculateNexFoodPosition() // JOSH: changed to public so it can be called from GameController
        {
            var emptyPositions = GetAllEmptyPositions();
            int index = Random.Shared.Next(emptyPositions.Count);
            (int x, int y) = emptyPositions[index];
            foodCoordinate = new Coordinate(x, y);
            SetFoodInBoard(x,y);
            return foodCoordinate;


        }

        public Food(Board board) 
        {
            this.board = board;
            
            foodCoordinate = CalculateNexFoodPosition();

        }

        
    }
}
