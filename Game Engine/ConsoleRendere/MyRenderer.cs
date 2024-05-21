using Game_Engine;
using PositionAssembly;
using System.Windows.Input;

namespace ConsoleRendere
{
    class MyRenderer : Renderer
    {
        private const ConsoleKey ShowBoardKey_TwoColors = ConsoleKey.A;
        private const ConsoleKey ShowBoardKey_OneColors = ConsoleKey.B;

        public void Render(Renderer renderer)
        {
            renderer.Render(this);
        }

        public void RenderScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the tile map engine rendere !!");
            Console.WriteLine("Press A to see the board with two colors");
            Console.WriteLine("Press B to see the board with one color");
            Console.WriteLine("Choose a key to start...");
            Console.ReadKey(true);
            ShowBoard();
        }

        public void ShowBoard()
        {
            ConsoleKey keyInfo = Console.ReadKey().Key;

            if (keyInfo == ShowBoardKey_TwoColors)
            {
                Console.Clear();
                Board();
            }

            else if (keyInfo == ShowBoardKey_OneColors)
            {
                Console.Clear();
                Console.WriteLine("Pressed B");
            }
        }

        public void Board()
        {
            // Define the size of the chessboard
            int boardSize = 8;

            // Column labels (numbers)
            Console.Write("  ");
            for (int col = 0; col < boardSize; col++)
            {
                //Console.Write($" {col + 1}");
            }
            Console.WriteLine();

            // Iterate through each row
            for (int row = -1; row < boardSize + 1; row++)
            {
                // Print the row labels
                if (row >= 0 && row < boardSize)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("  ");
                }

                // Iterate through each column in the current row
                for (int col = -1; col < boardSize + 1; col++)
                {
                    if (col == -1 || col == boardSize)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($" {row + 1}");
                    }

                    else if(row == -1 || row == boardSize)
                    {
                        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write($" {alphabet[7]}");
                    }

                    else
                    {
                        // Determine the color based on the position
                        if ((row + col) % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                        }

                        // Print the current cell with a space to separate columns
                        Console.Write("  "); // Two spaces to form a square-like cell
                    }
                }

                // Reset the background color and move to the next line after each row
                Console.ResetColor();
                Console.WriteLine();
            }

            // Reset the color to default
            Console.ResetColor();
        }


        public void ActivateRender()
        {
            RenderScreen();
        }
    }
}
