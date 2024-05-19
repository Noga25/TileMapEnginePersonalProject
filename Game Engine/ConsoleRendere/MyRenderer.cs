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
            for (int row = 0; row < boardSize; row++)
            {
                // Iterate through each column in the current row
                for (int col = 0; col < boardSize; col++)
                {
                    if(col % 2 == 0)
                    {
                        // Print the current cell's index in the format (row, column)
                        Console.Write($"({row}, {col}) ");
                    }

                    else if (col % 2 != 0)
                    {
                        // Print the current cell's index in the format (row, column)
                        Console.Write($"({row}, {col}) ");
                    }
                }
                // Print a newline character after each row to format the board correctly
                Console.WriteLine();
            }
        }

        public void ActivateRender()
        {
            RenderScreen();
        }
    }
}
