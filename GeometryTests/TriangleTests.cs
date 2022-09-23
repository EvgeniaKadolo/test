using System;
using Geometry;

namespace GeometryTests
{
    [TestFixture]
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 1, 0)]
        [TestCase(1, -1, 2)]
        [TestCase(10, 4, 5)]
        public void ConstructorFails_WhenSideIsInvalid(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [Test]
        public void GetArea()
        {
            Assert.That(new Triangle(12, 10, 10).Area, Is.EqualTo(48));
        }

        [Test]
        public void IsRightTriangle()
        {
            Assert.Multiple(() =>
            {
                Assert.That(new Triangle(12, 10, 10).RightTriangle, Is.EqualTo(false));
                Assert.That(new Triangle(3, 4, 5).RightTriangle, Is.EqualTo(true));
            });
        }
    }
}