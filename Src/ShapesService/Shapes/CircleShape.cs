using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesService.Shapes
{
    public class CircleShape : IShape
    {
        private double _Radius;

        public CircleShape(double radius)
        {
            if (radius <= 0 )
                throw new ArgumentException($"Can't create circle with radius = {radius}. The radius should be more than zero.");

            _Radius = radius;
        }

        public double Area() => Math.PI * Math.Pow(_Radius, 2);
     }
}
