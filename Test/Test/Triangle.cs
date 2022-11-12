using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLibrary
{
    public class Triangle : Figure
    {
        public override double CalculateArea(params double[] values)
        {
            double firstSide = values[0];
            double secondSide = values[1];
            double thirdSide = values[2];

            double semiperimeter = Semiperimeter(firstSide, secondSide, thirdSide);
            double square = Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));

            return Math.Round(square, 2); ;
        }

        private double Semiperimeter(double firstSide, double secondSide, double thirdSide)
        {
            double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            return semiperimeter;
        }

        public bool RightTriangle(params double[] values)
        {
            List<double> listSides = values.ToList();
            if (listSides.Count==3)
            {
                var maxValue = listSides.Max();
                listSides.Remove(maxValue);
                return Math.Pow(maxValue, 2) == Math.Pow(listSides[0], 2) + Math.Pow(listSides[1], 2);
            }
            return false;
        }
    }
}
