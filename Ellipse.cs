using System;

namespace shapes
{
    public class Ellipse : IWidget
    {
        Vector _location;
        Vector _size; // horizontal and vertical diameter stored as a vector for easier manipulation/calculation

        public Ellipse(Vector location, Vector size)
        {
            _location = new Vector(location);
            _size = new Vector(size);
        }

        // convenience constructor interface can be used if preferred
        public Ellipse(Vector location, int diameterH, int diameterV)
            : this(location, new Vector(diameterH, diameterV))
        {
        }

        // convenience constructor interface can be used if preferred
        public Ellipse(int x, int y, int diameterH, int diameterV)
            : this(new Vector(x, y), diameterH, diameterV)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1} diameterH = {2} diameterV = {3}", GetType().Name, _location, _size.X, _size.Y);
        }
    }
}
