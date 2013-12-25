using System.Collections.Generic;
using System.Linq;
using ConsoleApplication4;

namespace ButterfliesPuzzle
    {
    public class Card
        {
        public override string ToString()
            {
            return string.Format("CardNumber: {0}, Pieces: {1}", _cardNumber, _pieces);
            }

        private readonly int _cardNumber;    
        char _rotationChar = '^';
        private Dictionary<Direction,Piece> _pieces;

        public Card( int cardNumber, Piece piece1, Piece piece2, Piece piece3, Piece piece4 )
            {
            _cardNumber = cardNumber;
            _pieces = new Dictionary<Direction, Piece>
                {
                    { Direction.Up, piece1 },
                    { Direction.Right, piece2 }, 
                    { Direction.Down, piece3 },
                    { Direction.Left, piece4 }
                };
            }

        public void Rotate( Rotation rotation )
            {
            _pieces = _pieces.Select( pair => new { Key = pair.Key.Rotate(rotation), Value = pair.Value } ).ToDictionary( x=>x.Key, x=>x.Value );
            switch ( _rotationChar )
                {
                case '^': _rotationChar = '>'; break;
                case '>': _rotationChar = 'v'; break;
                case 'v': _rotationChar = '<'; break;
                case '<': _rotationChar = '^'; break;
                }
            }

        public Piece this[ Direction direction ]
            {
            get { return _pieces[ direction ]; }
            }

        public char      RotationChar
            {
            get { return _rotationChar; }
            }


        public string ToShortString()
            {
            return string.Format("   {4}  \n{2} {0}{1} {3}\n   {5}  ",_cardNumber,_rotationChar, _pieces[Direction.Left], _pieces[Direction.Right], _pieces[Direction.Up], _pieces[Direction.Down] );
            }
        }

    }