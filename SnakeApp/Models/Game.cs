namespace SnakeApp.Models
{
    public class Game  // This manages the state of the game
    {
        public Snake Snake { get; private set; }
        public Food Food { get; private set; }
        public Board Board { get; private set; }
        public int SpeedInput { get; }

        public Game()
        {            
            //Setting default speed
            Snake = new Snake(SpeedInput);
            Food = new Food();
            Board = new Board();
        }

        public Game(int speedInput)
        {
            SpeedInput = speedInput;
        }

        // Add methods for game logic such as starting, updating state, checking for game over, etc.
    }
}
