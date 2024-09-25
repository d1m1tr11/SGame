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

        public int X { get; set; }
        public int Y { get; set; }

        public Snake()
        {
            X = 25;
            Y = 15;
        }

        public void DrawSnake()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("■");
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                key = keyInfo.KeyChar;
            }
        }



    }


}
