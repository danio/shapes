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

            drawing.Add(new Square(15, 30, 35));

            Console.WriteLine(drawing);
        }
    }
}
