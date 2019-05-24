using NUnit.Framework;
using Mindbox;
using System;

namespace Tests
{
    public class CircleTests
    {
        [Test]
        public void Circle_NegativeRadius_ThrowException()
        {
            var expected = new Exception("Radius must be a positive number");
            var result = Assert.Throws<Exception>(() => new Circle(-1));

            Assert.That(expected.Message, Is.EqualTo(result.Message));
        }

        [Test]
        public void Circle_PositiveRadius_GetArea()
        {
            var setupCircle = new Circle(1);
            var expected = Math.PI;
            var result = setupCircle.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}