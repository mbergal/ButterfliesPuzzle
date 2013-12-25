using System;

namespace ButterfliesPuzzle
    {
    public class Position : IEquatable<Position>
        {
        public override string ToString()
            {
            return string.Format("X: {0}, Y: {1}", X, Y);
            }

        public int X { get; set; }
        public int Y { get; set; }

        public Position()
            {
            }

        public Position(int x, int y)
            {
            X = x;
            Y = y;
            }

        public static Position operator +( Position c1, Direction d ) 
            {
            return new Position { X = c1.X + d.DeltaX, Y = c1.Y + d.DeltaY };
            }

        public bool Equals(Position other)
            {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return X == other.X && Y == other.Y;
            }

        public override bool Equals(object obj)
            {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Position) obj);
            }

        public override int GetHashCode()
            {
            unchecked
                {
                return (X*397) ^ Y;
                }
            }

        public static bool operator ==(Position left, Position right)
            {
            return Equals(left, right);
            }

        public static bool operator !=(Position left, Position right)
            {
            return !Equals(left, right);
            }
        }
    }