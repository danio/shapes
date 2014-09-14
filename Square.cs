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

        public Square(int x, int y, int size)
        {
            _location = new Vector(x, y);
            _size = size;
        }

        public override string ToString()
        {
            return string.Format("Square {0} size={1}", _location, _size);
        }
    }
}
