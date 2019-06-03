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
        private Square square;
        private Rectangle rectangle;

        /// <summary>
        /// Sets up instances of objects for each test method.
        /// Using SetUp eliminates the need to reinitialize instances of objects in each test method. 
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            square = new Square();
            rectangle = new Rectangle();
        }

        [Test]
        public void SquareArea_WhenCalled_ReturnsArea()
        {
            // Setup
            square.Side = 2;

            // Execution 
            int square_area = square.Area();

            // Expectations
            Assert.That(square_area, Is.EqualTo(4));
            Assert.That(square_area, Is.Not.EqualTo(4));
        }

        [Test]
        public void RectangleArea_WhenCalled_ReturnsArea()
        {
            rectangle.Length = 5;
            rectangle.Side = 2;

            // Execution
            int rectangle_area = rectangle.Area();

            // Expectations
            Assert.That(rectangle_area, Is.EqualTo(10));
            Assert.That(rectangle_area, Is.Not.EqualTo(3));
        }
    }
}
