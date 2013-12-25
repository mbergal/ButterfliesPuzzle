using ConsoleApplication4;
using FluentAssertions;
using NUnit.Framework;

namespace ButterfliesPuzzle.Tests
    {
    [TestFixture]
    public class GameTest
        {
        [Test]
        public void TestPosition()
            {
            var field = new GameField();
            field.Place( new Card[,] 
                { 
                { Cards.Card7,Cards.Card8,Cards.Card9 },
                { Cards.Card4,Cards.Card5,Cards.Card6 },
                { Cards.Card1,Cards.Card2,Cards.Card3 }
                } );
            field.Get( new Position { X = 1, Y = 1 } ).Should().Be( Cards.Card5 );

            ( new Position( 1, 1 )+ Direction.Down ).Should().Be(new Position(1,0) );
            }

        [Test]
        public void TestRotation()
            {
            var direction = Direction.Up;
            direction.Rotate(Rotation.Rotation90).Should().Be( Direction.Right );
            direction.Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Should().Be( Direction.Down );
            direction.Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Should().Be( Direction.Left );
            direction.Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Should().Be( Direction.Up );
            }

        [Test]
        public void TestDirections()
            {
            var field = new GameField();
            field.Place( new Card[,] 
                { 
                { Cards.Card7,Cards.Card8,Cards.Card9 },
                { Cards.Card4,Cards.Card5,Cards.Card6 },
                { Cards.Card1,Cards.Card2,Cards.Card3 }
                } );

            field.IsValid( new Position( 0, 0 ) ).Should().BeTrue();
            field.NoMismatches( new Position( 1, 1 ) ).Should().BeFalse();

            field.Place( new Card[,] 
                { 
                { null, null, null },
                { null,Cards.Card5,null },
                { null,null,null }
                } );
            field.NoMismatches( new Position( 1, 1 ) ).Should().BeTrue();

            field.Place( new Card[,] 
                { 
                { null, null, null },
                { null,Cards.Card5,null },
                { null,null,null }
                } );


            }
        }
    }