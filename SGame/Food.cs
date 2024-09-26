using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGame
{




    public class Food
    {

        public Position foodPosition = new Position();
        Random rnd = new Random();
        Canvas canvas = new Canvas();

        public Food()
        {
            foodPosition.X = rnd.Next(5, canvas.Width);
            foodPosition.Y = rnd.Next(5, canvas.Height);
        }



        public void DrawFood()
        {
            Console.SetCursorPosition(foodPosition.X, foodPosition.Y);
            Console.Write("X");
        }

        public Position FoodLocation()
        {
            return foodPosition;
        }

        public void FoodNewLocation()
        {
            foodPosition.X = rnd.Next(5, canvas.Width);
            foodPosition.Y = rnd.Next(5, canvas.Height);

        }








    }
}
