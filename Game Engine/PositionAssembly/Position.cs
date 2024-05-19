using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionAssembly
{
    namespace Positioning
    {
        /// <summary>
        /// Interface for 2D positions
        /// <summary>
        interface IPosition
        {
            int X { get; }
            int Y { get; }
        }

        /// <summary>
        /// Implementation of 2D positions
        /// </summary>
        public readonly struct Position : IPosition // + 1 to every thing
        {
            public int X { get; }
            public int Y { get; }

            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }

            /// <summary>
            /// Provide a string representation of the position
            /// </summary>
            /// <returns></returns>
            public readonly override string ToString()
            {
                return $"({X}, {Y})";
            }

            /// <summary>
            /// Provide hash code for the position
            /// </summary>
            /// <returns></returns>
            public readonly override int GetHashCode()
            {
                return X.GetHashCode() ^ Y.GetHashCode();
            }

            /// <summary>
            /// Compare positions for equality
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public readonly override bool Equals(object obj)
            {
                if (!(obj is Position))
                    return false;

                var other = (Position)obj;
                return X == other.X && Y == other.Y;
            }
        }

        /// <summary>
        /// Represents individual tiles on the tilemap
        /// </summary>
        abstract public class TileIndex
        {
            public Position Position { get; set; }
            public string Type { get; set; }

            public TileIndex(Position position, string type)
            {
                Position = position;
                Type = type;
            }
        }

        internal class TileMapIndex
        {
            private List<TileIndex> tiles;

            public TileMapIndex()
            {
                tiles = new List<TileIndex>();
            }

            /// <summary>
            /// Indexer for positions
            /// </summary>
            /// <param name="position"></param>
            /// <returns></returns>
            public TileIndex this[Position position]
            {
                get
                {
                    return tiles.FirstOrDefault(tile => tile.Position.Equals(position));
                }
                set
                {
                    // If the position already exists, update the tile at that position
                    var existingTile = tiles.FirstOrDefault(tile => tile.Position.Equals(position));
                    if (existingTile != null)
                    {
                        existingTile.Type = value.Type;
                    }
                    else
                    {
                        // If they exist, add a new tile at the specified position
                        value.Position = position;
                        tiles.Add(value);
                    }
                }
            }
        }
    }
}
