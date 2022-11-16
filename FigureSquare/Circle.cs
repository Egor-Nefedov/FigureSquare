using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare
{
    internal class Circle
    {
        double Radius { get; set; }
        public Circle(double _Radius)
        {
            Radius = _Radius;
        }

        public double CircleSquare()
        {
            var Square = Math.Round(Math.PI * Math.Pow(Radius, 2),2);
            return Square;
        }
    }
}
