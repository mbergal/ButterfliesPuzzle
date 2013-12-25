using System;
using System.Linq;
using ConsoleApplication4;

namespace ButterfliesPuzzle
    {
    public class Game
        {
        public Game()
            {
            _field = new GameField();
            }

        protected GameField _field;

        public void Try( Position pos, Card[] cards )
            {
            foreach (Card card in cards) 
                {
                for( int j = 0; j < 4; j++ )
                    {
                    _field.Put( pos, card );
                    if ( _field.NoMismatches( pos ) )
                        {
                        var nextPos = _field.NextPos( pos );
                        var nextCards = cards.Where( x=>x!=card ).ToArray();
                        if ( nextCards.Length == 0 )
                            {
                            Console.WriteLine( "Solution !!!" );
                            Console.WriteLine( _field );
                            }
                        else
                            {
                            Try( nextPos, nextCards );
                            }
                        }
                    card.Rotate(Rotation.Rotation90);
                    }
                _field.Put( pos, null );
                }
            }

        public void Run()
            {
            var cards = new []
                {
                Cards.Card1,
                Cards.Card2,
                Cards.Card3,
                Cards.Card4,
                Cards.Card5,
                Cards.Card6,
                Cards.Card7,
                Cards.Card8,
                Cards.Card9
                };

            

            var pos = new Position( 0, 0 );

            Try( pos, cards );

            }
        }
    }