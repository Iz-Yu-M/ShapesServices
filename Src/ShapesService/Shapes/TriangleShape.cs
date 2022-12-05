using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesService.Shapes
{
    public class TriangleShape : IShape
    {
        private double _AB;
        private double _BC;
        private double _CA;

        private double _P { get => (_AB + _BC + _CA) / 2; }

        public TriangleShape(double edgeAB, double edgeBC, double edgeCA)
        {
            if (edgeAB <= 0 || edgeBC <= 0 || edgeCA <= 0)
                throw new ArgumentException($"Can't create triangle with edges {edgeAB}, {edgeBC}, {edgeCA}. The edges should be more than zero.");
            _AB = edgeAB;
            _BC = edgeBC;
            _CA = edgeCA;
        }

        public double Area() => Math.Sqrt(_P * (_P - _AB) * (_P - _BC) * (_P - _CA));

        /// <summary>
        /// Проверка является ли прямоугольник прямым
        /// </summary>
        /// <returns></returns>

        public bool IsRightTriangle()
        {
            var edges = new List<double> { _AB, _BC, _CA }.OrderBy(side => side).ToList();
            double sideA = edges[0];
            double sideB = edges[1];
            double hypotenuse = edges[2];

            return Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(hypotenuse, 2);
        }
    }
}
