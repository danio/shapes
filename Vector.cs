using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    // General type that represents a two-dimensional vector
    // e.g. a point, location
    class Vector
    {
        int _x;
        int _y;

        public Vector(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", _x, _y);
        }
    }
}
