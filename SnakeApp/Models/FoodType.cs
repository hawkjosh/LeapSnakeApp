using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp.Models
{
    public class FoodType
    {
        private string Display { get; }

        private FoodType(string display)
        {
            Display = display;
        }

        public override string ToString()
        {
            return Display;
        }

        public  static FoodType[] GetAllFoodTypes()
        {
            return [Apple, Pineapple, Grapes, Banana, Strawberry, Chicken];
        }
        //  Console.OutputEncoding = System.Text.Encoding.UTF8; right before you output heart 2
        public static FoodType Apple { get { return new FoodType("A"); } }
        public static FoodType Pineapple { get { return new FoodType("P"); } }
        public static FoodType Grapes { get { return new FoodType("G"); } }
        public static FoodType Banana { get { return new FoodType("B"); } }
        public static FoodType Strawberry { get { return new FoodType("S"); } }
        public static FoodType Chicken { get { return new FoodType("C"); } }
    }
}
