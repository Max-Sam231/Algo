internal class Program
{

    static void Main(string[] args)
    {
        var add = (int a, int b) => a + b;
        var substract = (int a, int b) => a - b;
        var multiply = (int a, int b) => a * b;
        var divide = (int a, int b) => b != 0 ? a / b : throw new DivideByZeroException("Деление на ноль");
        Console.WriteLine(add(50, 2));
        Console.WriteLine(substract(54, 2));
        Console.WriteLine(multiply(13, 4));
        Console.WriteLine(divide(104, 2));

        List<string> spsk = ["апвара", "мапвара", "Мпвара", "апв",];
        var FirstM = (List<string> spsk) =>
        {
            foreach (var word in spsk)
            {
                if (word.ToLower().StartsWith("м"))
                    Console.WriteLine(word);
            }
        };
        FirstM(spsk);
    }
}