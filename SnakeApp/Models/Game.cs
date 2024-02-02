namespace SnakeApp.Models
{
    public class Game  // This manages the state of the game
    {
        public Snake Snake { get; private set; }
        public Food Food { get; private set; }
        public Board Board { get; private set; }
        public int SpeedInput { get; }

        public Game(int speedInput)
        {
            SpeedInput = speedInput;
            Snake = new Snake(SpeedInput);

            Board = new Board();
            Food = new Food(Board);
        }

        // Add methods for game logic such as starting, updating state, checking for game over, etc.
    }
}
