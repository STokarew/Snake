using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 30);
            Console.SetBufferSize(120, 30);
            HorizontalLine upLine = new HorizontalLine(0, 119, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 119, 28, '+');
            VerticalLine leftLine = new VerticalLine(0, 28, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 29, 119, '+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadKey();
        }

    }
}
