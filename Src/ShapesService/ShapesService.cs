using ShapesService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesService
{
    public class ShapesService : IShapesService
    {
        public double CalculateArea(IShape shape) => shape.Area();
    }
}
