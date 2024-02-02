namespace SnakeApp.Models
{
    public class Board  // This deals with the dimensions and boundaries of the game area
    {
        public int width;
        public int height;
        public Tile[,] map;

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
        
    }
}
