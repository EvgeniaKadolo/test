using System;
using Geometry;

namespace GeometryTests
{
    [TestFixture]
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InitializeCircleCorrectly()
        {
            Assert.That(new Circle(2).Radius, Is.EqualTo(2));
        }

        [Test]
        public void InitializeCircleWithZeroRadius()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0));
        }

        [Test]
        public void InitializeCircleWithNegativeRadius()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-10));
        }

        [Test]
        public void GetArea()
        {
            Assert.That(new Circle(34).Area, Is.EqualTo(3631.681107549801));
        }
    }

}