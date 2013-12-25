using ConsoleApplication4;

namespace ButterfliesPuzzle
    {
    public static class Cards 
        {
        public static readonly Card Card1 = new Card( 1, Piece.BlueTop, Piece.RedBottom, Piece.BrownBottom, Piece.YellowBottom );
        public static readonly Card Card2 = new Card( 2, Piece.BlueBottom, Piece.BrownTop, Piece.YellowBottom, Piece.RedBottom );
        public static readonly Card Card3 = new Card( 3, Piece.YellowTop, Piece.RedTop, Piece.BlueTop, Piece.BrownBottom );
        public static readonly Card Card4 = new Card( 4, Piece.BrownBottom, Piece.BlueTop, Piece.RedTop, Piece.YellowBottom );
        public static readonly Card Card5 = new Card( 5, Piece.YellowBottom, Piece.YellowTop, Piece.RedBottom, Piece.BlueTop );
        public static readonly Card Card6 = new Card( 6, Piece.BlueBottom, Piece.RedBottom, Piece.BrownBottom, Piece.YellowTop );
        public static readonly Card Card7 = new Card( 7, Piece.BlueBottom, Piece.RedBottom, Piece.YellowBottom, Piece.BrownTop );
        public static readonly Card Card8 = new Card( 8, Piece.BlueTop, Piece.BlueBottom, Piece.RedTop, Piece.BrownTop );
        public static readonly Card Card9 = new Card( 9, Piece.BlueTop, Piece.RedBottom, Piece.YellowBottom, Piece.BrownTop );
        }
    }