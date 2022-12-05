using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesService.Interfaces
{
    internal interface IShapesService
    {
        public double CalculateArea(IShape shape);
    }
}
