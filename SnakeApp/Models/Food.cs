using SnakeApp.Interfaces;

namespace SnakeApp.Models
{
    public class Food : ICurrentPosition  // This manages the position and type of food items on the board
    {
        // TODO: Add properties and methods
        private FoodType foodType;
        private Coordinate foodCoordinate; 
        
        public FoodType FoodType { get { return foodType; } }   
        public Coordinate GetCurrentPosition()
        {
            return foodCoordinate;
        }

        //Method to select position and type of food.
        public void RenewFood(int x,int y)
        {
            foodCoordinate = new Coordinate(x, y);
            foodType = SelectRandomFoodType();
        }
        private FoodType SelectRandomFoodType()
        {
            var allFoodTypes = FoodType.GetAllFoodTypes();
            Random r = new Random();
            var randomFoodTypeIndex = r.Next(0, allFoodTypes.Length-1);
            return allFoodTypes[randomFoodTypeIndex];
        }
        public Food(int x, int y) 
        {
            RenewFood(x, y);
        }

        
    }
}
