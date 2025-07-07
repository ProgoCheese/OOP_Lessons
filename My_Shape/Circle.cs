namespace ShapeTask
{
    public class Circle(double radius) : Shape
    {
        public double radius = radius;

        public new double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public new double GetPerimeter()
        {
            return Math.PI * radius * 2;
        }

        public new double GetHeight()
        {
            return 2 * radius;
        }

        public new double GetWidth()
        {
            return radius * 2;
        }
    }
}
