﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Rectangle : IWidget
    {
        Vector _location;
        Vector _size; // width and height stored as a vector for easier manipulation/calculation

        public Rectangle(Vector location, Vector size)
        {
            _location = new Vector(location);
            _size = new Vector(size);
        }

        // convenience constructor interface can be used if preferred
        public Rectangle(Vector location, int width, int height)
            : this(location, new Vector(width, height))
        {
            _location = new Vector(location);
            _size = new Vector(width, height);
        }

        // convenience constructor interface can be used if preferred
        public Rectangle(int x, int y, int width, int height)
            : this(new Vector(x, y), width, height)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1} width={2} height={3}", GetType().Name, _location, _size.X, _size.Y);
        }
    }
}