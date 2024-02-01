namespace SnakeApp.Models
{
    public class Board  // This deals with the dimensions and boundaries of the game area
    {
        private int width;
        private int height;
        private Tile[,] map;

        // TODO: Add properties and methods to manage the board
        public Board()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            map = new Tile[width, height];
        }

        public List<(int X, int Y)> GetAllEmptyPositions()
        {
            List<(int X, int Y)> emptyPossitions = new();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (map[i, j] is Tile.Empty)
                    {
                        emptyPossitions.Add((i, j));
                    }
                }
            }
            return emptyPossitions;
        }

        public void SetFoodInBoard(int x, int y)
        {
            map[x, y] = Tile.Food;
        }
        public void PrintBoard(Food food)
        {

            Console.Clear();
            Console.SetCursorPosition(food.GetCurrentPosition().X, food.GetCurrentPosition().Y);
            Console.Write(food.FoodType);
            // Add logic to print empty board, food in board and snake in board.
        }
    }
}
