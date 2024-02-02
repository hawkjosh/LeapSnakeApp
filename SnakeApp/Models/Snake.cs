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
            SnakeCoordinate = new Coordinate(Console.WindowWidth / 2, Console.WindowHeight / 2);
            SnakeQueue = new Queue<Coordinate>();
        }

        private void SetSnakeSpeed(int speed)
        {
            switch(speed)
            {
                case 1:
                    SnakeSpeed = Speed.Slow; break;
                case 2:
                    SnakeSpeed = Speed.Medium; break;
                case 3:
                    SnakeSpeed = Speed.Fast; break;
            }
        }

        public TimeSpan GetSnakeSleepDuration()
        {
            //int[] snakeVelocityConversionArray = [200, 140, 100];
            int[] snakeVelocityConversionArray = [125, 100, 75];
            var velocity = snakeVelocityConversionArray[(int)SnakeSpeed - 1];
            TimeSpan timeToSleep = TimeSpan.FromMilliseconds(velocity);
            return timeToSleep;
        }


    }
}
