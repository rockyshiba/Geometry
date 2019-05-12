using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Geometry;

namespace Geometry.UnitTests
{
    [TestFixture]
    public class GeometryTests
    {
        [Test]
        public void SquareArea_WhenCalled_ReturnsArea()
        {
            // Setup
            Square square = new Square()
            {
                Side = 2
            };

            // Execution 
            int square_area = square.Area();

            // Expectations
            Assert.That(square_area, Is.EqualTo(4));
            Assert.That(square_area, Is.Not.EqualTo(4));
        }

        [Test]
        public void RectangleArea_WhenCalled_ReturnsArea()
        {
            // Setup
            Rectangle rectangle = new Rectangle()
            {
                Length = 5,
                Side = 2
            };

            // Execution
            int rectangle_area = rectangle.Area();

            // Expectations
            Assert.That(rectangle_area, Is.EqualTo(10));
            Assert.That(rectangle_area, Is.Not.EqualTo(3));
        }
    }
}
