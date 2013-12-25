using System;
using ConsoleApplication4;

namespace ButterfliesPuzzle
    {
    public class Direction : IEquatable<Direction>
        {
        public static readonly Direction Left           = new Direction { DeltaX = -1, DeltaY = 0 };
        public static readonly Direction Right          = new Direction { DeltaX = 1, DeltaY = 0 };
        public static readonly Direction Up             = new Direction { DeltaX = 0, DeltaY = 1 };
        public static readonly Direction Down           = new Direction { DeltaX = 0, DeltaY = -1 };

        public static readonly Direction[] Directions   = new[] { Left, Right, Up, Down };

        public Direction() {}
        public Direction( int deltaX, int deltaY )
            {
            DeltaX = deltaX;
            DeltaY = deltaY;
            }

        public Direction       Opposite()
            {
            return new Direction { DeltaX = -this.DeltaX, DeltaY = -this.DeltaY };
            }

        public Direction       Rotate( Rotation rotation )
            {
            return new Direction( DeltaX * rotation.P1 + DeltaY * rotation.P2, DeltaX * rotation.P3 + DeltaY * rotation.P4 );
            }

        public int DeltaX { get; set; }
        public int DeltaY { get; set; }

        public bool Equals(Direction other)
            {
            return DeltaX == other.DeltaX && DeltaY == other.DeltaY;
            }

        public override bool Equals(object obj)
            {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Direction && Equals((Direction) obj);
            }

        public override int GetHashCode()
            {
            unchecked
                {
                return (DeltaX*397) ^ DeltaY;
                }
            }

        public static bool operator ==(Direction left, Direction right)
            {
            return left.Equals(right);
            }

        public static bool operator !=(Direction left, Direction right)
            {
            return !left.Equals(right);
            }


        }
    }