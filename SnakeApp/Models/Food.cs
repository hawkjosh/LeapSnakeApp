
using SnakeApp.Interfaces;

namespace SnakeApp.Models
{

    public class Food : ICurrentPosition  // This manages the position and type of food items on the board
    {
        // TODO: Add properties and methods
        
        private Coordinate foodCoordinate; 
        

        public Coordinate GetCurrentPosition()
        {
            return foodCoordinate;
        }

        //Method to select position and type of food.
        public Coordinate RenewFood(int x,int y)
        {
            foodCoordinate = new Coordinate(x, y);

        }

        public Food(int x, int y) 

        {

            RenewFood(x, y);
        }




        
    }
}
