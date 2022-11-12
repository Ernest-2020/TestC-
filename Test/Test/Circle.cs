using System;

namespace MyLibrary
{
    public class Circle: Figure
    {
        private const double degreForCalculateArea = 2;
 
        public override  double CalculateArea(params double[] values)
        {
            double radius = values[0];
            double square = Math.PI * Math.Pow(radius, degreForCalculateArea);
            
            return Math.Round(square, 2);
        }
    }
}
