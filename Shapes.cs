using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Shapes
    {
        static void Main(string[] args)
        {
            Drawing drawing = new Drawing();

            drawing.Add(new Rectangle(location: new Vector(10, 10), width: 30, height: 40));
            drawing.Add(new Square(location: new Vector(15, 30), size: 35));
            drawing.Add(new Ellipse(location: new Vector(100, 150), diameterH: 300, diameterV: 200));
            drawing.Add(new Circle(location: new Vector(1, 1), diameter: 300));

            Console.WriteLine(drawing);
        }
    }
}
