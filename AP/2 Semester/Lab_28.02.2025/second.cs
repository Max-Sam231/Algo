internal class Program
{
    // На вход подается список числовых значений.
    //  Необходимо с помощью множества определить элементы, из которых состоит список. 
    // Необходимо выдать частоту появления каждого элемента(с использованием Dictionary)
    static void Main(string[] args)
    {
        string userString = Console.ReadLine();
        List<char> elemArray= new List<char>();
        for (int i = 0; i < userString.Length; i++)
        {
            elemArray.Add(userString[i]);
        }
        HashSet<char> elemArrayUniqe = [.. elemArray];
        Console.WriteLine("[{0}]", String.Join(',',elemArrayUniqe));
        Dictionary<char, int> ResArray = new Dictionary<char, int>();
        foreach (char item in elemArray)
        {
         if(ResArray.ContainsKey(item)){
            ResArray[item]++;
         }   else{
            ResArray[item] = 1;
         }
        }
        foreach (var pair in ResArray)
        {
            Console.WriteLine($"Элемент: {pair.Key}, Количество: {pair.Value}");
        }
    }
}