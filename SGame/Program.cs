using SGame;


bool finished = false;
var canvas = new Canvas();
var snake = new Snake();

while (!finished)
{

    canvas.DrawCanvas();
    snake.DrawSnake();
    Console.Read();
}
