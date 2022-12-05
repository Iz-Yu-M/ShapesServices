using ShapesService.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesService.UnitTests.Shapes
{
    public class CircleTests
    {
        [Fact]
        public void ZeroRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new CircleShape(0));
        }
        [Fact]
        public void NegativRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new CircleShape(-10));
        }
        [Fact]
        public void AreaTest()
        {
            var shape = new CircleShape(10);
            Assert.Equal(314, (int)shape.Area());
        }
    }
}
