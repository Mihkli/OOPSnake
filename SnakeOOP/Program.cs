using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            point p1 = new point(10,10, '*');
            point p2 = new point(11, 10, '*');

            //HorizontalLine hline = new HorizontalLine(10,14, 5, '*');       
            //VerticalLine vline = new VerticalLine(6, 16, 10, '@');

            HorizontalLine top = new HorizontalLine(0, 80, 0, '#');
            top.Draw();
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            left.Draw();
            HorizontalLine bot = new HorizontalLine(0, 80, 25, '#');
            bot.Draw();
            VerticalLine right = new VerticalLine(0, 25, 80, '#');
            right.Draw();

            point snaketail = new point(15, 15, 's');
            Snake snake = new Snake(snaketail, 5, Direction.RIGHT);
            snake.Draw();

            FoodGenerator foodGenerator = new FoodGenerator(80,25,'$');
            point food = foodGenerator.GenerateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodGenerator.GenerateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekeys(key.Key);
                }
                Thread.Sleep(300);
                //snake.Move();
            }
            
            Console.ReadLine();
        }
    }
}
