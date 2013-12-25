using FluentAssertions;
using NUnit.Framework;

namespace ButterfliesPuzzle.Tests
    {
    [TestFixture]
    public class RotationTest
        {
        [Test]
        public void Should_correctly_rotate_direction()
            {
            var direction = Direction.Up;
            direction.Rotate(Rotation.Rotation90).Should().Be( Direction.Right );
            direction.Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Should().Be( Direction.Down );
            direction.Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Should().Be( Direction.Left );
            direction.Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Rotate(Rotation.Rotation90).Should().Be( Direction.Up );
            }
        }
    }
