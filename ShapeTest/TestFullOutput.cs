using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using shapes;

namespace ShapeTest
{
    // More of an integration test than a unit test, but usign unit test framework as it's easy to manage
    [TestClass]
    public class TestFullOutput
    {
        [TestMethod]
        public void TestSampleFromSpec()
        {
            string expectedOutput = @"----------------------------------------------------------------
Current Drawing
----------------------------------------------------------------
Rectangle (10,10) width=30 height=40
Square (15,30) size=35
Ellipse (100,150) diameterH = 300 diameterV = 200
Circle (1,1) size=300
Textbox (5,5) width=200 height=100 Text=";
            expectedOutput = expectedOutput + "\"sample text\"" + Environment.NewLine;
            expectedOutput = expectedOutput + "----------------------------------------------------------------" + Environment.NewLine;

            Drawing drawing = new Drawing();

            drawing.Add(new Rectangle(location: new Vector(10, 10), width: 30, height: 40));
            drawing.Add(new Square(location: new Vector(15, 30), size: 35));
            drawing.Add(new Ellipse(location: new Vector(100, 150), diameterH: 300, diameterV: 200));
            drawing.Add(new Circle(location: new Vector(1, 1), diameter: 300));
            drawing.Add(new Textbox(location: new Vector(5, 5), width: 200, height: 100, text: "sample text"));

            Assert.AreEqual(expectedOutput, drawing.ToString());

        }
    }
}
