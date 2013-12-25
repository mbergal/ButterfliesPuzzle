using System.Text;
using ConsoleApplication4;

namespace ButterfliesPuzzle
    {
    public class GameField  
        {
        private readonly Card[,] _field;

        public GameField()
            {
            _field = new Card[,]
                { 
                    { null, null, null }, 
                    { null, null, null },
                    { null, null, null } 
                };
            }

        public override string ToString()
            {
            var sb = new StringBuilder();
            for ( int i = 2; i >= 0; i-- )
                {
                var lb = new StringLineBuilder();
                for ( int j = 0; j < 3; ++j )
                    {
                    var card = this.Get( new Position(j,i));
                    lb.Append( card != null ? card.ToShortString() : "     " );
                    }
                sb.AppendLine( lb.ToString() );
                }
            sb.AppendLine("---" );
            return sb.ToString();
            }

        public void Put(Position pos, Card card)
            {
            _field[ pos.Y, pos.X ] = card;
            }


        public bool NoMismatches( Position pos )
            {
            var thisCard = this.Get( pos );
            foreach( var d in Direction.Directions )
                {
                var otherPos = pos + d;
                if ( IsValid( otherPos ) )
                    {
                    var otherCard = this.Get( otherPos );
                    if ( !Matches( thisCard, otherCard, d ) ) return false;
                    }
                }
            return true;
            }

        private bool Matches( Card thisCard, Card otherCard, Direction direction)
            {
            if ( thisCard == null || otherCard == null ) return true;

            var thisCardPiece = thisCard[ direction ];
            var otherCardPiece = otherCard[ direction.Opposite() ];

            if ( thisCardPiece.Type != otherCardPiece.Type ) return false;
            if ( thisCardPiece.Part == otherCardPiece.Part ) return false;

            return true;
            }

        public void Place(Card[,] cards)
            {
            for( int i = 0; i < 3; ++i )
                for( int j = 0; j < 3; ++j )
                    _field[i,j] = cards[i,j];
            }

        public Card Get(Position position)
            {
            return _field[ position.Y, position.X ];
            }

        public bool IsValid(Position position)
            {
            if ( position.X < 0 ) return false;
            if ( position.Y < 0 ) return false;
            if ( position.X > 2 ) return false;
            if ( position.Y > 2 ) return false;
            return true;
            }

        public Position NextPos(Position pos)
            {
            return pos.X + 1 > 2 ? new Position( 0, pos.Y + 1 ) : new Position( pos.X + 1, pos.Y );
            }
        }
    }