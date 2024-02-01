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

        
    }
}
