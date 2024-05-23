using PositionAssembly.Positioning;

namespace CoreEngineHirechy
{
    public class Player
    {
        public int PlayerID { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public List<TileObject> PiecesOwned { get; private set; } = new List<TileObject>();
        public ConsoleColor PiecesColor { get; private set; }
        public int MovesToX { get; private set; }
        public int MovesToY { get; private set; }

        private const int MinMoveValue = -1;
        private const int MaxMoveValue = 1;

        public Player(int playerID, ConsoleColor piecesColor, int movesToX, int movesToY, params TileObject[] pawns) : this(playerID, piecesColor, movesToX, movesToY)
        {
            foreach (var pawn in pawns)
            {
                pawn.Color = piecesColor;
                PiecesOwned.Add(pawn);
            }
        }

        public Player(int playerID, ConsoleColor piecesColor, int movesToX, int movesToY)
        {
            if (movesToX < MinMoveValue || movesToX > MaxMoveValue)
            {
                throw new Exception("movesToX must be between -1 to 1");
            }
            if (movesToY < MinMoveValue || movesToY > MaxMoveValue)
            {
                throw new Exception("movesToY must be between -1 to 1");
            }

            PlayerID = playerID;
            PiecesColor = piecesColor;
            MovesToX = movesToX;
            MovesToY = movesToY;
        }
    }

    public class TileObject
    {
        public string TileObjectChar { get; set; }
        public Position[] Positions { get; set; }
        public Position CurrentPos { get; set; }
        public Player Owner { get; set; }
        public ConsoleColor Color { get; set; }
        public List<Position> PossiblePositions { get; internal set; }

        public TileObject(string tileObjectChar, Position[] tileObjrctPositions, Position startingPos, ConsoleColor color)
            : this(tileObjectChar, tileObjrctPositions, startingPos, null, color)
        {
        }

        public TileObject(string tileObjectChar, Position[] tileObjrctPositions, Position startingPos, Player owner)
            : this(tileObjectChar, tileObjrctPositions, startingPos, owner, owner?.PiecesColor ?? ConsoleColor.White)
        {
        }

        private TileObject(string tileObjectChar, Position[] tileObjrctPositions, Position startingPos, Player owner, ConsoleColor color)
        {
            TileObjectChar = tileObjectChar;
            Positions = tileObjrctPositions;
            PossiblePositions = new List<Position>();
            Owner = owner;
            Color = color;

            foreach (Position pos in Positions)
            {
                PossiblePositions.Add(pos);
            }

            CurrentPos = startingPos;
        }

        public object Clone()
        {
            return new TileObject(TileObjectChar, Positions, CurrentPos, Owner);
        }

        public object CloneToPos(Position newPos)
        {
            return new TileObject(TileObjectChar, Positions, newPos, Owner);
        }

        public object CloneOwnerless()
        {
            return new TileObject(TileObjectChar, Positions, CurrentPos, Color);
        }

        public object CloneToPosOwnerless(Position newPos)
        {
            return new TileObject(TileObjectChar, Positions, newPos, Color);
        }
    }
}
