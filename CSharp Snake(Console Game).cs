using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    struct Position
    {
        public int row;
        public int col;
        public Position(int x, int y)
        {
            this.row = x;
            this.col = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(70, 40);

            Console.BackgroundColor = ConsoleColor.White;

            Position[] directions = new Position[]
            {
                new Position ( 0 ,1), // right
                new Position (0, -1), // left
                new Position (1, 0),// down
                new Position (-1, 0), // up
            };
            int direction = 0; //0
            Random randomNumberGenerator = new Random();
            Console.BufferHeight = Console.WindowHeight;
            Position food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));
            Console.SetCursorPosition(food.col, food.row);
            Console.Write("@");

            Queue<Position> snakeElements = new Queue<Position>();

            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*");
                Console.ForegroundColor = ConsoleColor.White;
            }

            while (true)
            {
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo userImput = Console.ReadKey();

                    if (userImput.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    if (userImput.Key == ConsoleKey.LeftArrow)
                    {
                        direction = 1;
                    }
                    if (userImput.Key == ConsoleKey.RightArrow)
                    {
                        direction = 0;
                    }
                    if (userImput.Key == ConsoleKey.UpArrow)
                    {
                        direction = 3;
                    }
                    if (userImput.Key == ConsoleKey.DownArrow)
                    {
                        direction = 2;
                    }
                }
                Position snakeHead = snakeElements.Last();
                Position nextDirection = directions[direction];
                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);
                if (true)
                {
                    // wallsTeleport
                    if (snakeNewHead.col > Console.WindowWidth - 1)
                    {
                        snakeNewHead.col = 1;
                    }
                    if (snakeNewHead.col < 0)
                    {
                        snakeNewHead.col = Console.WindowWidth - 1;
                    }
                    if (snakeNewHead.row > Console.WindowHeight - 1)
                    {
                        snakeNewHead.row = 1;
                    }
                    if (snakeNewHead.row < 0)
                    {
                        snakeNewHead.row = Console.WindowHeight - 1;

                    }
                    //wallsTeleport
                } //wallsTeleport
                snakeElements.Enqueue(snakeNewHead);

                if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)
                {
                    food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));

                    //TODO: 
                }
                else
                {
                    snakeElements.Dequeue();

                }
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                foreach (Position position in snakeElements)
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.WriteLine("*");
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(food.col, food.row);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("@");
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(100);

            }
        }
    }
}
