using SnakeApp.Interfaces;

namespace SnakeApp.Models
{
    public class Snake  : ICurrentPosition // This handles the snake's attributes like length, position, movement, etc.
    {
        // TODO: Add properties and methods to manage the snake
        private Speed snakespeed;
        private Direction snakeDirection;
        public Speed SnakeSpeed
        {
            get { return snakespeed; }
            set { snakespeed = value; }
        }
        public Direction SnakeDirection
        {
            get { return snakeDirection; }
            set { snakeDirection = value; }
        }
        public Coordinate SnakeCoordinate { get; set; }
        public int SnakeLength { get; set; }
        public Queue<Coordinate> SnakeQueue { get; set; }

        public int SnakeColor { get; set; }
        public int ChangeLength(int changeInLength)
        {
            return SnakeLength + changeInLength;
        }

        public Coordinate GetCurrentPosition()
        {
            return SnakeCoordinate;
        }

        public Snake(int speed)
        {
            SetSnakeSpeed(speed);
        }

        private void SetSnakeSpeed(int speed)
        {
            switch(speed)
            {
                case 0:
                    SnakeSpeed = Speed.Slow; break;
                case 1:
                    SnakeSpeed = Speed.Medium; break;
                case 2:
                    SnakeSpeed = Speed.Fast; break;
            }
        }
    }
}
