using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Square : IWidget
    {
        int _size;
        Vector _location;

        public Square(Vector location, int size)
        {
            _location = new Vector(location);
            _size = size;
        }

        // convenience constructor interface can be used if preferred
        public Square(int x, int y, int size) : this(new Vector(x, y), size)
        {
        }

        public override string ToString()
        {
            return string.Format("Square {0} size={1}", _location, _size);
        }
    }
}
