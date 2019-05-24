using NUnit.Framework;
using Mindbox;
using System;

namespace Tests
{
    class TriangeTests
    {
        [Test]
        public void Triangle_NegativeSide_ThrowException()
        {
            var expected = new Exception("All sides must be positive");
            var result = Assert.Throws<Exception>(() => new Triangle(-1, 2, 2));

            Assert.That(expected.Message, Is.EqualTo(result.Message));
        }

        [Test]
        public void Triangle_RightTriangle_GetArea()
        {
            var setupTriangle = new Triangle(3, 4, 5);
            var expected = 6;
            var result = setupTriangle.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Triangle_CasualTriangle_GetArea()
        {
            var setupTriangle = new Triangle(4, 13, 15);
            var expected = 24;
            var result = setupTriangle.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void Triangle_BoxingAsFigure_GetArea()
        {
            var setupTriangle = new Triangle(4, 13, 15);
            Figure figure = (Figure)setupTriangle;
            var expected = 24;
            var result = figure.GetArea();

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
