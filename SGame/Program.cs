using SGame;


public class Program
{
    private static void Main(string[] args)
    {
        bool finished = false;
        var canvas = new Canvas();
        var snake = new Snake();
        var food = new Food();



        while (!finished)
        {
            canvas.DrawCanvas();
            snake.DrawSnake();
            food.DrawFood();
            snake.Input();
            snake.MoveSnake();
            snake.SnakeGrow(food.FoodLocation(),food);



        }
    }
}