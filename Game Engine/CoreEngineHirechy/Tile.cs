using PositionAssembly.Positioning;

namespace CoreEngineHirechy
{
    public class Tile
    {
        public TileMap Map { get; set; }
        public Position Position { get; set; }
        public List<TileObject> TileObjects { get; set; }

        public Tile(TileMap map, Position position)
        {
            Map = map;
            Position = position;
            TileObjects = new List<TileObject>();
        }
    }
}
