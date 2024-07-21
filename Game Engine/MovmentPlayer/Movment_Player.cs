using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovmentPlayer
{
    internal struct Movment_Player
    {
        private const string Player = "0";

        private int x = 0;
        private int y = 0;

        public Movment_Player(int startX, int startY)
        {
            x = startX;
            y = startY;
            Console.Clear(); 
            Write(Player, x, y);
        }

        public void MovePlayer()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var command = Console.ReadKey(true).Key;

                    switch (command)
                    {
                        case ConsoleKey.Z:
                            Move(0, 1);
                            break;

                        case ConsoleKey.X:
                            Move(0, -1);
                            break;

                        case ConsoleKey.C:
                            Move(-1, 0);
                            break;

                        case ConsoleKey.V:
                            Move(1, 0);
                            break;
                    }
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        private void Move(int deltaX, int deltaY)
        {
            // current position
            Console.SetCursorPosition(x, y);
            Console.Write(" ");

            // Update position
            x += deltaX;
            y += deltaY;

            // make sure position is within the bounds
            x = Math.Max(0, x);
            y = Math.Max(0, y);

            // show the player at the new position
            Write(Player, x, y);
        }

        private void Write(string toWrite, int x1, int y1)
        {
            try
            {
                Console.SetCursorPosition(x1, y1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(toWrite);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Out of board boundaries");
            }
        }
    }
}
