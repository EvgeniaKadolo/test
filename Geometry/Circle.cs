using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException();
            }
            Radius = radius;
        }

        public double Area
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }
    }
}
