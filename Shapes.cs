﻿using System;

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
            drawing.Add(new Textbox(location: new Vector(5, 5), width: 200, height: 100, text: "sample text"));

            Console.WriteLine(drawing);
        }
    }
}
