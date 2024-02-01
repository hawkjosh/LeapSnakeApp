namespace SnakeApp.Models
{
    public class Board  // This deals with the dimensions and boundaries of the game area
    {
        // TODO: Add properties and methods to manage the board
        private Coordinate coordinates;

        public Coordinate Coordinates { get; set; }

        public Board()
        {
            Coordinates = new Coordinate();
            Coordinates.X = Console.WindowWidth;
            Coordinates.Y = Console.WindowHeight;
        }
    }
}
