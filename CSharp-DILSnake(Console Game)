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
            Position[] directions = new Position[]
            {
                new Position ( 0 ,1), // right
                new Position (0, -1), // left
                new Position (1, 0),// down
                new Position (-1, 0), // up
            };
            int direction = 0; //0
            int counter = 0;
            Console.SetWindowSize(70, 40);

            

            Random randomNumberGenerator = new Random();
            Console.BufferHeight = Console.WindowHeight;
            Console.BackgroundColor = ConsoleColor.White;

            Position foodD = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));
            Position foodI = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));
            Position foodL = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));
            Position foodo = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));
            Position foodg = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));
            Position foodi = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));
            Position foodc = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowWidth));



            Queue<Position> snakeElements = new Queue<Position>();

            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));

            }

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.White;


            bool food1 = true;
            bool food2 = true;
            bool food3 = true;
            bool food4 = true;
            bool food5 = true;
            bool food6 = true;
            bool food7 = true;


            while (counter < 7)
            {
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo userImput = Console.ReadKey();

                    if (userImput.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    if (userImput.Key == ConsoleKey.Enter)
                    {
                        counter = 7;
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


                if (snakeNewHead.col == foodD.col && snakeNewHead.row == foodD.row)
                {

                    food1 = false;
                    counter++;
                }


                else if (snakeNewHead.col == foodI.col && snakeNewHead.row == foodI.row)
                {

                    food2 = false;
                    counter++;
                }

                else if (snakeNewHead.col == foodL.col && snakeNewHead.row == foodL.row)
                {

                    food3 = false;
                    counter++;
                }

                else if (snakeNewHead.col == foodo.col && snakeNewHead.row == foodo.row)
                {

                    food4 = false;
                    counter++;
                }

                else if (snakeNewHead.col == foodg.col && snakeNewHead.row == foodg.row)
                {

                    food5 = false;
                    counter++;
                }

                else if (snakeNewHead.col == foodi.col && snakeNewHead.row == foodi.row)
                {

                    food6 = false;
                    counter++;
                }

                else if (snakeNewHead.col == foodc.col && snakeNewHead.row == foodc.row)
                {

                    food7 = false;
                    counter++;
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




                Console.ForegroundColor = ConsoleColor.Black;

                if (food1 == true)
                {
                    Console.SetCursorPosition(foodD.col, foodD.row);
                    Console.WriteLine("D");
                }
                if (food2 == true)
                {
                    Console.SetCursorPosition(foodI.col, foodI.row);
                    Console.WriteLine("I");
                }
                if (food3 == true)
                {
                    Console.SetCursorPosition(foodL.col, foodL.row);
                    Console.WriteLine("L");
                }
                if (food4 == true)
                {
                    Console.SetCursorPosition(foodo.col, foodo.row);
                    Console.WriteLine("o");
                }
                if (food5 == true)
                {
                    Console.SetCursorPosition(foodg.col, foodg.row);
                    Console.WriteLine("g");
                }
                if (food6 == true)
                {
                    Console.SetCursorPosition(foodi.col, foodi.row);
                    Console.WriteLine("i");
                }
                if (food7 == true)
                {
                    Console.SetCursorPosition(foodc.col, foodc.row);
                    Console.WriteLine("c");
                }
                Console.ForegroundColor = ConsoleColor.White;


                Thread.Sleep(250);

            }
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                        YOU WIN WITH DILOGIC !!!");
            Thread.Sleep(10000);
        }
    }
}
