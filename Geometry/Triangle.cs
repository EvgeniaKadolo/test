using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide > 0 && secondSide > 0 && thirdSide > 0
                && firstSide + secondSide > thirdSide
                && firstSide + thirdSide > secondSide
                && secondSide + thirdSide > firstSide)
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public double Area
        {
            get 
            {
                double semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2;
                return Math.Sqrt( 
                    semiperimeter 
                    * (semiperimeter - FirstSide) 
                    * (semiperimeter - SecondSide) 
                    * (semiperimeter - ThirdSide)
                );
            }
        }

        public bool RightTriangle
        {
            get
            {
                double[] sides = { FirstSide, SecondSide, ThirdSide };
                Array.Sort(sides);

                if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
