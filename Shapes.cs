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

            drawing.Add(new Rectangle(new Vector(10, 10), 30, 40));
            drawing.Add(new Square(new Vector(15, 30), 35));
            drawing.Add(new Ellipse(new Vector(100, 150), 300, 200));

            Console.WriteLine(drawing);
        }
    }
}
