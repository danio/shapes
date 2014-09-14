using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using shapes;

namespace ShapeTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void ConvenienceConstructorShouldHaveSameEffectAsLocationConstructor()
        {
            Vector location = new Vector(3,7);
            int size = 42;
            Square square1 = new Square(location, size);
            Square square2 = new Square(location.X, location.Y, size);

            Assert.AreEqual(square1.ToString(), square2.ToString());
        }
    }
}
