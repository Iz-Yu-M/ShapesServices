using ShapesService.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesService.UnitTests
{
    public class ShapesServiceTests
    {
        [Fact]
        public void CalculateAreaTest()
        {
            var shapes = new List<IShape>
            {
                new CircleShape(10),
                new TriangleShape(6, 8, 10)
            };
            var service = new ShapesService();
            Assert.Equal(Math.PI * 100, service.CalculateArea(shapes[0]));
            Assert.Equal(24d, service.CalculateArea(shapes[1]));
        }
    }
}
