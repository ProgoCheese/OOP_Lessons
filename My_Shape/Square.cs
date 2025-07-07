namespace ShapeTask
{
    public class Square(double width) : Shape
    {
        public double width = width;

        public new double GetArea()
        {
            return width * width;
        }

        public new double GetPerimeter()
        {
            return width * 4;
        }

        public new double GetHeight()
        {
            return width;
        }

        public new double GetWidth()
        {
            return width;
        }
    }
}
