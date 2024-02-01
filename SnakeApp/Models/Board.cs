namespace SnakeApp.Models
{
    public class Board  // This deals with the dimensions and boundaries of the game area
    {
        // TODO: Add properties and methods to manage the board
        public int Width { get; set; }
        public int Height { get; set; }
        public int[,] Cells { get; set; }

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new int[width, height];
        }
    }
}
