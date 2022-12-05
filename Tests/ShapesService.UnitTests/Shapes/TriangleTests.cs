using ShapesService.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesService.UnitTests.Shapes
{
    public class TriangleTests
    {
        [Fact]
        public void ZeroEdgesTest()
        {
            Assert.Throws<ArgumentException>(() => new TriangleShape(0, 8, 10));
            Assert.Throws<ArgumentException>(() => new TriangleShape(6, 0, 10));
            Assert.Throws<ArgumentException>(() => new TriangleShape(6, 8, 0));
            Assert.Throws<ArgumentException>(() => new TriangleShape(0, 0, 0));
        }
        [Fact]
        public void NegativEdgesTest()
        {
            Assert.Throws<ArgumentException>(() => new TriangleShape(-6, 8, 10));
            Assert.Throws<ArgumentException>(() => new TriangleShape(6, -8, 10));
            Assert.Throws<ArgumentException>(() => new TriangleShape(6, 8, -10));
            Assert.Throws<ArgumentException>(() => new TriangleShape(-6, -8, -10));
        }
        [Fact]
        public void AreaTest()
        {
            var shape = new TriangleShape(6, 8, 10);
            Assert.Equal(24, shape.Area());
        }
        [Fact]
        public void IsRightTriangleTest()
        {
            var shape = new TriangleShape(10, 8, 6);
            Assert.True(shape.IsRightTriangle());
        }
        [Fact]
        public void IsNotRightTriangleTest()
        {
            var shape = new TriangleShape(6, 9, 10);
            Assert.False(shape.IsRightTriangle());
        }

    }
}
