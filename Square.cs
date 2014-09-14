using System;

namespace shapes
{
    class Square : IWidget
    {
        Vector _location;
        int _size;

        public Square(Vector location, int size)
        {
            _location = new Vector(location);
            _size = size;
        }

        // convenience constructor interface can be used if preferred
        public Square(int x, int y, int size)
            : this(new Vector(x, y), size)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1} size={2}", this.GetType().Name, _location, _size);
        }
    }
}
