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

            // Iterate through each row
            for (int row = -1; row < boardSize + 1; row++)
            {
                // Iterate through each column in the current row
                for (int col = 0; col < boardSize; col++)
                {
                    if(row == - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }

                    // Determine the color based on the position
                    if ((row + col) % 2 == 0 && row >= 0 && row != boardSize)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else if(row != - 1) 
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }

                    else if (row == boardSize)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    // Print the current cell with a space to separate columns
                    Console.Write("  "); // Two spaces to form a square-like cell
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
