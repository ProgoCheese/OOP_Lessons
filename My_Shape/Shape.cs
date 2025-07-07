namespace ShapeTask
{
    public class Shape
    {
        public double GetWidth()
        {
            return 0;
        }

        public double GetHeight()
        {
            return 0;
        }

        public double GetArea()
        {
            return 0;
        }

        public double GetPerimeter()
        {
            return 0;
        }
    }

    class ProgrammShape()
    {
        private static double GetReadNumber(string userLine)
        {
            Console.WriteLine(userLine);

            return Convert.ToDouble(Console.ReadLine());
        }

        private static void PrintShapeStatus(Square shape)
        {
            Console.WriteLine("Квадрат. Длина: " + shape.GetWidth() + ". Высота: " + shape.GetHeight() + ". Перимерт: " + shape.GetPerimeter() + ". Площадь:" + shape.GetArea());
        }

        private static void PrintShapeStatus(Triangle shape)
        {
            Console.WriteLine("Треугольник. Длина: " + shape.GetWidth() + ". Высота: " + shape.GetHeight() + ". Перимерт: " + shape.GetPerimeter() + ". Площадь:" + shape.GetArea());
        }

        private static void PrintShapeStatus(Rectangle shape)
        {
            Console.WriteLine("Прямоугольник. Длина: " + shape.GetWidth() + ". Высота: " + shape.GetHeight() + ". Перимерт: " + shape.GetPerimeter() + ". Площадь:" + shape.GetArea());
        }

        private static void PrintShapeStatus(Circle shape)
        {
            Console.WriteLine("Круг. Длина: " + shape.GetWidth() + ". Высота: " + shape.GetHeight() + ". Перимерт: " + shape.GetPerimeter() + ". Площадь:" + shape.GetArea());
        }

        private static Triangle GetTriangle()
        {
            return new Triangle(GetReadNumber("Введите координату x первой точки"), GetReadNumber("Введите координату y первой точки"), GetReadNumber("Введите координату x второй точки"), GetReadNumber("Введите координату y второй точки"), GetReadNumber("Введите координату x третьей точки"), GetReadNumber("Введите координату y третьей точки"));
        }

        private static void GetMaxArea(double[] area)
        {

        }

        private static void Main()
        {
            //Square square = new Square(GetReadNumber("Введите сторону квадрата."));
            //PrintShapeStatus(square);

            //Triangle triangle = GetTriangle();
            //PrintShapeStatus(triangle);

            //Rectangle rectangle = new Rectangle(GetReadNumber("Длина прямоугольника: "), GetReadNumber("Высота прямоугольника"));
            //PrintShapeStatus(rectangle);

            //Circle circle = new Circle(GetReadNumber("Радиус:"));
            //PrintShapeStatus(circle);

            Square square1 = new Square(5);

            Square square2 = new Square(7);

            Triangle triangle1 = new Triangle(1, 5, 3, 1, 2, 4);

            Triangle triangle2 = new Triangle(4,2,6,7,1,3);

            Rectangle rectangle1 = new Rectangle(5, 7);

            Rectangle rectangle2 = new Rectangle(3, 6);

            Circle circle1 = new Circle(5);

            Circle circle2 = new Circle(7);

            double[] shapeArea = new double[] { square1.GetArea(), square2.GetArea(), triangle1.GetArea(), triangle2.GetArea(), rectangle1.GetArea(), rectangle2.GetArea(), circle1.GetArea(), circle2.GetArea()};

            GetMaxArea(shapeArea);
        }
    }
}
