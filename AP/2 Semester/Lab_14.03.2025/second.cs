// 2. Класс "Машины" и описываются они годом выпуска, моделью, цвет, машина чистая или грязная(bool).
//  Класс "Гараж", который содержит все машины. 
// Класс "Мойка", в котором будет реализован только 1 метод, моющий машину, если она грязная(машина ... помыта или нет).
//  Будет делегат, который будет отправлять машины в мойку.

using System.Runtime.InteropServices;

internal class Program
{
    public class Car
    {
        public string Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsWash { get; set; }
        public Car(string year, string model, string color, bool isWash)
        {
            Year = year;
            Model = model;
            Color = color;
            IsWash = isWash;
        }
    }
    public class Garage
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public void AddCar(Car car) => Cars.Add(car);
    }

    public class Washing
    {
        public void WashCar(Car car)
        {
            if (car.IsWash) { Console.WriteLine("Машина уже помыта"); } else { car.IsWash = true; Console.WriteLine("Машина помыта"); }
        }
    }

    public delegate void WashDelegate(Car car, Washing washer   );

    static void Main(string[] args)
    {
        Garage garage = new Garage();
        garage.AddCar(new Car("2025", "Toyota", "Black", true));
        garage.AddCar(new Car("2015", "Kia", "Red", false));
        Washing washing = new Washing();

        WashDelegate washDelegate = (car, washer)=> washer.WashCar(car);

        foreach (var car in garage.Cars)
        {
            washDelegate(car, washing);
        }
    }
}