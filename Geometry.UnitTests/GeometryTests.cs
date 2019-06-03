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
        [TestCase(2, 4)] // instead of writing individual methods for each test case, the TestCase attribute uses parameters to run tests
        [TestCase(1, 1)]
        [TestCase(3, 9)]
        public void SquareArea_WhenCalled_ReturnsArea(int side, int expectedResult)
        {
            // Setup
            square.Side = side;

            // Execution 
            int square_area = square.Area();

            // Expectations
            Assert.That(square_area, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(2, 3)]
        [TestCase(1, 0)]
        [TestCase(4, 2)]
        public void SquareArea_WhenCalled_ReturnsWrongArea(int side, int expectedResult)
        {
            // Setup
            square.Side = side;

            // Execution
            int square_area = square.Area();

            // Expectations
            Assert.That(square_area, Is.Not.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5, 2, 10)]
        [TestCase(1, 1, 1)]
        [TestCase(3, 4, 12)]
        public void RectangleArea_WhenCalled_ReturnsArea(int length, int side, int expectedResult)
        {
            // Setup
            rectangle.Length = length;
            rectangle.Side = side;

            // Execution
            int rectangle_area = rectangle.Area();

            // Expectations
            Assert.That(rectangle_area, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5, 2, 1)]
        [TestCase(1, 1, 9)]
        [TestCase(3, 3, 11)]
        public void RectangleArea_WhenCalled_ReturnsWrongArea(int length, int side, int expectedResult)
        {
            // Setup
            rectangle.Length = length;
            rectangle.Side = side;

            // Execution
            int rectangle_area = rectangle.Area();

            // Expectations
            Assert.That(rectangle_area, Is.Not.EqualTo(expectedResult));
        }
    }
}
