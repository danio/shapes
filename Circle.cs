﻿using System;

namespace shapes
{
    public class Circle : IWidget
    {
        Vector _location;
        int _diameter;

        public Circle(Vector location, int diameter)
        {
            _location = new Vector(location);
            _diameter = diameter;
        }

        // convenience constructor interface can be used if preferred
        public Circle(int x, int y, int diameter)
            : this(new Vector(x, y), diameter)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1} size={2}", this.GetType().Name, _location, _diameter);
        }
    }}
