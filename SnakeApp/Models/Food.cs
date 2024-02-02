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
            for (int i = 0; i < board.width; i++)
            {
                for (int j = 0; j < board.height; j++)
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



        private Coordinate CalculateNexFoodPosition()
        {
            var emptyPositions = GetAllEmptyPositions();
            int index = Random.Shared.Next(emptyPositions.Count);
            (int x, int y) = emptyPositions[index];
            foodCoordinate = new Coordinate(x, y);
            return foodCoordinate;


        }

        public Food(Board board) 
        {
            this.board = board;
            
            foodCoordinate = CalculateNexFoodPosition();

        }

        
    }
}
