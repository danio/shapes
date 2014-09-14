using System;

namespace shapes
{
    // General type that represents a two-dimensional vector
    // e.g. a point, location
    public class Vector
    {
        int _x;
        int _y;

        public Vector(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Vector(Vector v)
        {
            _x = v._x;
            _y = v._y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value;  }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", _x, _y);
        }
    }
}
