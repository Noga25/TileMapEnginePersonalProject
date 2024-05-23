using PositionAssembly.Positioning;

namespace CoreEngineHirechy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Player player = new Player(1, ConsoleColor.White, 0, 1, new TileObject("P", new[] { new Position(0, 0) }, new Position(0, 0), null));
        }
    }
}
