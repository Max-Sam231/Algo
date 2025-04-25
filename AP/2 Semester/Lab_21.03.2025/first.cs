//1. Имеется класс "точка", который описывается двумя координатами. 
// Есть поле, заданное 4 координатами. 
// Точка перемещается по полю с рандомными значегиями по x и y. 
// Необходимо обработать события выхода точки за пределы поля.

internal class Program
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public delegate void OutBorderHandler(string message);
        public event OutBorderHandler OutBorder;

        public Point(int y, int x)
        {
            X = x;
            Y = y;
        }

        public void RandomPosition(Field field)
        {
            Random random = new Random();
            int newX = random.Next(-5, 21);
            int newY = random.Next(-5, 21);

            bool isOutOfBounds =
                newX < field.TopX || newX > field.BottomX ||
                newY < field.TopY || newY > field.BottomY;

            if (isOutOfBounds)
            {
                OutBorder($"Точка ({X},{Y}) вышла за границы в ({newX},{newY})");
            }

            X = newX;
            Y = newY;
            Console.WriteLine($"Точка переместилась в ({X}, {Y})");
        }
    }

    public class Field
    {
        public int TopX { get; set; }
        public int BottomX { get; set; }
        public int TopY { get; set; }
        public int BottomY { get; set; }

        public Field(int topX, int bottomX, int topY, int bottomY)
        {
            TopX = topX;
            BottomX = bottomX;
            TopY = topY;
            BottomY = bottomY;
        }
    }

    public class OutBorder
    {
        public void Message(string message)
        {
            Console.WriteLine($"{message}");
        }
    }

    static void Main(string[] args)
    {
        Field field = new Field(5, 15, 5, 15);
        Point point = new Point(6, 6);
        OutBorder handler = new OutBorder();
        point.OutBorder += handler.Message;

        for (int i = 0; i < 5; i++)
        {
            point.RandomPosition(field);
        }
    }
}