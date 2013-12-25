using System;

namespace ButterfliesPuzzle
    {
    public class Piece
        {
        private readonly ButterflyPart _part;
        private readonly ButterflyType _type;

        public static readonly  Piece BlueBottom = new Piece( ButterflyType.Blue, ButterflyPart.Bottom );
        public static readonly  Piece BlueTop = new Piece( ButterflyType.Blue, ButterflyPart.Top );
        public static readonly  Piece RedBottom = new Piece( ButterflyType.Red, ButterflyPart.Bottom );
        public static readonly  Piece RedTop = new Piece( ButterflyType.Red, ButterflyPart.Top );
        public static readonly  Piece YellowBottom = new Piece( ButterflyType.Yellow, ButterflyPart.Bottom );
        public static readonly  Piece YellowTop = new Piece( ButterflyType.Yellow, ButterflyPart.Top );
        public static readonly  Piece BrownBottom = new Piece( ButterflyType.Brown, ButterflyPart.Bottom );
        public static readonly  Piece BrownTop = new Piece( ButterflyType.Brown, ButterflyPart.Top );

        public ButterflyPart Part
            {
            get { return _part; }
            }

        public ButterflyType Type
            {
            get { return _type; }
            }

        public Piece( ButterflyType type, ButterflyPart part  )
            {
            _part = part;
            _type = type;
            }

        public override string ToString()
            {
            string typeChar;
            switch (Type)
                {
                case ButterflyType.Blue: typeChar = "B"; break;
                case ButterflyType.Yellow: typeChar = "Y"; break;
                case ButterflyType.Red: typeChar = "R"; break;
                case ButterflyType.Brown: typeChar = "W"; break;
                default:
                    throw new ArgumentOutOfRangeException();
                }
            return _part == ButterflyPart.Top ? typeChar.ToLower() : typeChar;
            }
        }
    }