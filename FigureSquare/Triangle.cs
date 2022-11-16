using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    internal class Triangle
    {
        double first { get; set; }
        double second { get; set; }
        double third { get; set; }
        public Triangle(double _first, double _second, double _third)
        {
            first = _first;
            second = _second;
            third = _third;
        }

        public double TriangleSquare()
        {
            var SemiPerimetr = (first + second + third) / 2;
            var Square = Math.Round(Math.Sqrt(SemiPerimetr*(SemiPerimetr-first) *(SemiPerimetr-second) *(SemiPerimetr-third)), 2);
            return Square;
        }
    }
}
