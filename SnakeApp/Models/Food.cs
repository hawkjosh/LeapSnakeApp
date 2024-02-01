
using SnakeApp.Interfaces;

namespace SnakeApp.Models
{
    public class Food : ICurrentPosition // This manages the position and type of food items on the board
    {
        private Coordinate foodCoordinate;

        public Coordinate FoodCoordinate { get; private set; }
        
        public Coordinate GetCurrentPosition()
        {
            return FoodCoordinate;
        }

        // TODO: Add properties and methods to manage the food
        internal Coordinate UpdateFoodPosition()
        {
            //Update logic to be added
            return FoodCoordinate;
        }
    }
}
