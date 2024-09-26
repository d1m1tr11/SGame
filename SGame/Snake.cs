using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGame
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char direction = 'u';


        List<Position> snakeBody;

        public int X { get; set; }
        public int Y { get; set; }

        public Snake()
        {
            X = 25;
            Y = 15;

            snakeBody = new List<Position>();
            snakeBody.Add(new Position(X, Y));


        }

        public void DrawSnake()
        {
            foreach (Position i in snakeBody)
            {
            Console.SetCursorPosition(i.X, i.Y);
            Console.WriteLine("■");
            }
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        private void Direction()
        {
            if(key == 'w' &&  direction != 'd')
            {
                direction = 'u';
            }

            else if (key == 's' &&  direction != 'u')
            {
                direction = 'd';
            }

            else if (key == 'd' &&  direction != 'l')
            {
                direction = 'r';
            }

            else if(key == 'a' &&  direction != 'r')
            {
                direction = 'l';
            }

        }


        public void MoveSnake()
        {

            Direction();

            if(direction == 'u')
            {
                Y--;
            }

            else if(direction == 'd')
            {
                Y++;
            }
            
            else if(direction == 'l')
            {
                X--;
            }
            
            else if(direction == 'r')
            {
                X++;
            }

            
            snakeBody.Add(new Position(X, Y));
            snakeBody.RemoveAt(0);
            Thread.Sleep(100);


        }


        public void SnakeGrow(Position food, Food f)
        {
            Position sn = snakeBody[snakeBody.Count - 1];

            if(sn.X == food.X && sn.Y == food.Y)
            {
                snakeBody.Add(new Position(X, Y));
                f.FoodNewLocation();
            }


        }

    }


}
