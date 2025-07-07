namespace ShapeTask
{
    public class Triangle : Shape
    {
        private double x1, y1, x2, y2, x3, y3;

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public double GetFirstSide()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public double GetSecondSide()
        {
            return Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
        }

        public double GetThirdSide()
        {
            return Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        }

        public new double GetPerimeter()
        {
            return GetFirstSide() + GetSecondSide() + GetThirdSide();
        }

        public new double GetArea()
        {
            double semiPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - GetFirstSide()) * (semiPerimeter - GetSecondSide()) * (semiPerimeter - GetThirdSide()));
        }

        public new double GetHeight()
        {
            double area = GetArea();
            double baseLength = GetFirstSide();
            return (2 * area) / baseLength;
        }

        public new double GetWidth()
        {
            return Math.Max(Math.Max(x1, x2), x3) - Math.Min(Math.Min(x1, x2), x3);
        }
    }
}