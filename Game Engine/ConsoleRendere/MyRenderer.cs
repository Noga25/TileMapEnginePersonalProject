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
            Console.WriteLine("Press any key to start...");
            Console.ReadKey(true);
            ShowBoard();
        }

        public void ShowBoard()
        {
            ConsoleKey keyInfo = Console.ReadKey().Key;

            if (keyInfo == ShowBoardKey_TwoColors)
            {
                Console.Clear();
                Console.WriteLine("Pressed A");
            }

            else if (keyInfo == ShowBoardKey_OneColors)
            {
                Console.Clear();
                Console.WriteLine("Pressed B");
            }
        }

        public void ActivateRender()
        {
            RenderScreen();
        }
    }
}
