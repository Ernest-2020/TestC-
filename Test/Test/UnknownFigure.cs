namespace MyLibrary
{
    public class UnknownFigure : Figure
    {
        public override double CalculateArea(params double[] values)
        {
            double square;
            switch (values.Length)
            {
                case 1:
                    Circle circle = new Circle();
                    square = circle.CalculateArea(values[0]);
                    return square;
                case 3:
                    Triangle triangle = new Triangle();
                    square = triangle.CalculateArea(values[0], values[1], values[2]);
                    return square;
            }

            return 0;
        }
    }
}
