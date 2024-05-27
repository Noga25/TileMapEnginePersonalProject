using PositionAssembly.Positioning;

namespace CoreEngineHirechy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TileMap tileMap = new TileMap();
            Player player = new Player(1, ConsoleColor.White, 0, 1, new TileObject("P", new[] { new Position(3, 4) }, new Position(3, 4), null));
            tileMap.Board();
        }
    }
}
