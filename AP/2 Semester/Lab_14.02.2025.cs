
internal class Program
{
    public interface IShape
    {
        double Area();
        double Perimeter();

    }
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }
    }

    public class Circle : Shape, IShape
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
        public double Perimeter()
        {
            return 2 * Radius * Math.PI;
        }
    }

    public class Square : Shape, IShape
    {
        public double LenghtSide { get; set; }
        public Square(string name, double lenghtSide) : base(name)
        {
            LenghtSide = lenghtSide;
        }
        public double Area()
        {
            return LenghtSide * LenghtSide;
        }
        public double Perimeter()
        {
            return LenghtSide * 4;
        }
    }


    public class Trangle : Shape, IShape
    {
        public double LenghtSide { get; set; }
        public Trangle(string name, double lenghtSide) : base(name)
        {
            LenghtSide = lenghtSide;
        }
        public double Area()
        {
            return Math.Sqrt(3 / 4) * Math.Pow(LenghtSide, 2);
        }
        public double Perimeter()
        {
            return LenghtSide * 3;
        }
    }

    static void Main(string[] args)
    {
        Circle circle = new Circle("Окружность", 1);
        Square square = new Square("Квадрат", 1);
        Trangle triangle = new Trangle("Треугольник", 1);
        Console.WriteLine(circle.Area());
        Console.WriteLine(circle.Perimeter());

        Console.WriteLine(square.Area());
        Console.WriteLine(square.Perimeter());

        Console.WriteLine(triangle.Area());
        Console.WriteLine(triangle.Perimeter());
        
    }
}