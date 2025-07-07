namespace ShapeTask
{
    public class Rectangle(double width, double height) : Shape
    {
        public double width = width;
        public double height = height;

        public new double GetArea()
        {
            return width * height;
        }

        public new double GetPerimeter()
        {
            return (width + height) * 2;
        }

        public new double GetHeight()
        {
            return height;
        }

        public new double GetWidth()
        {
            return width;
        }
    }
}
