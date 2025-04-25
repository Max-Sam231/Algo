// 1. Класс с двумя переменными целого типа и будут реализованы следующие методы: сложение, 
// разность первого и второго элемента, умножение, целочисленное деление первого на второй элемент(проверка на 0 обязательна). 
// Описан делегат(тип и сигнатура на свое усмотрение). Необходимо создать 2 объекта заданного класса, будет  2 экземпляра делегата. 
// Первый работает с первым объектом и включает группу операторов(суммирование, результат суммирования, умноженный на второй элемент, деление результата, который был получен на предыдущем шаге на второй элемент). 
// Второй работает со вторым объектом, реализует операции(деление первого на второй, вычитание из результата деления второго элемента, умножение, полученного результата на второй элемент).

internal class Program
{
    public class Calculator
    {
        public int First { get; set; }
        public int Second { get; set; }
        public Calculator(int first, int second)
        {
            First = first;
            Second = second;
        }
        public int Add() => First + Second;
        public int Subtract() => First - Second;
        public int Multiply() => First * Second;
        public int Divide()
        {
            if (Second == 0)
            {
                throw new DivideByZeroException("Попытка деления на ноль");
            }
            return First / Second;
        }

    }
    public delegate int CalculatorDelegate(Calculator calc);
    static void Main(string[] args)
    {
        Calculator calc1 = new Calculator(10, 5);
        Calculator calc2 = new Calculator(20, 4);

        CalculatorDelegate delegate1 =(calc)=>{
            int sum = calc.Add();
            int multiply = sum * calc.Second;
            return multiply / calc.Second;
        };
        CalculatorDelegate delegate2 = (calc) =>
        {
            int division = calc.Divide();
            int subtracted = division - calc.Second;
            return subtracted * calc.Second;
        };
        Console.WriteLine(delegate1(calc1));
        Console.WriteLine(delegate1(calc2));
    }
}