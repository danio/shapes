using System;

namespace shapes
{
    class Textbox : IWidget
    {
        Vector _location;
        Vector _size; // width and height stored as a vector for easier manipulation/calculation
        string _text;

        public Textbox(Vector location, Vector size, string text)
        {
            _location = new Vector(location);
            _size = new Vector(size);
            _text = text;
        }

        // convenience constructor interface can be used if preferred
        public Textbox(Vector location, int width, int height, string text)
            : this(location, new Vector(width, height), text)
        {
        }

        // convenience constructor interface can be used if preferred
        public Textbox(int x, int y, int width, int height, string text)
            : this(new Vector(x, y), width, height, text)
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1} width={2} height={3} Text=\"{4}\"", GetType().Name, _location, _size.X, _size.Y, _text);
        }
    }
}
