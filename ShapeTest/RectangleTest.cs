using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using shapes;

namespace ShapeTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void ConvenienceConstructorsShouldHaveSameEffectAsLocationConstructor()
        {
            Vector location = new Vector(3, 7);
            Vector size = new Vector(42, 77);
            Rectangle standardConstructed = new Rectangle(location, size);
            Rectangle convenienceConstructed1 = new Rectangle(location, size.X, size.Y);
            Rectangle convenienceConstructed2 = new Rectangle(location.X, location.Y, size.X, size.Y);

            Assert.AreEqual(standardConstructed.ToString(), convenienceConstructed1.ToString());
            Assert.AreEqual(standardConstructed.ToString(), convenienceConstructed2.ToString());
        }
    }
}
