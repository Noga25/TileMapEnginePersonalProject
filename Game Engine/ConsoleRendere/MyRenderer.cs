using Game_Engine;
using PositionAssembly;
using System.Windows.Input;

namespace ConsoleRendere
{
    class MyRenderer : Renderer
    {
        private const ConsoleKey ShowBoardKey = ConsoleKey.A;

        public void Render(Renderer renderer)
        {
            renderer.Render(this);
        }

        public void RenderScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the tile map engine rendere, Press A to see the board!");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey(true);
            ShowBoard();
        }

        public void ShowBoard()
        {
            ConsoleKey keyInfo = Console.ReadKey().Key;

            if (keyInfo == ShowBoardKey)
            {
                Console.Clear();
                Console.WriteLine("Pressed");
            }
        }

        public void ActivateRender()
        {
            RenderScreen();
        }
    }
}
