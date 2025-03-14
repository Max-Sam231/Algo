using System.Linq.Expressions;

internal class Program
{
    public class Phone
    {
        public string PhoneNumber { get; set; }
        public string Provider { get; set; }
        public string Rate { get; set; }

        public Phone(string phoneNumber, string provider, string rate)
        {
            PhoneNumber = phoneNumber;
            Provider = provider;
            Rate = rate;

        }
    }
    static void Main(string[] args)
    {
        bool flag = true;
        List<Phone> elemArray = new List<Phone>();
        while (flag)
        {
            Console.WriteLine("Введите номер телефона");
            string userStringNumber = Console.ReadLine();
            Console.WriteLine(userStringNumber);
            Console.WriteLine("Введите оператора");
            string userStringProvider = Console.ReadLine();
            Console.WriteLine("Введите стоимость тарифа");
            string userStringRate = Console.ReadLine();
            elemArray.Add(new Phone(userStringNumber, userStringProvider, userStringRate));
            Console.WriteLine("Добавить еще один номер да/нет");
            string userStringFlag = Console.ReadLine().ToLower();
            Console.WriteLine(userStringFlag);
            switch (userStringFlag)
            {
                case "нет":
                    flag = false;
                    break;
                case "да":
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }
        }

        Dictionary<string, int> ResArray = new Dictionary<string, int>();
        foreach (Phone item in elemArray)
        {
            if (ResArray.ContainsKey(item.Provider))
            {
                ResArray[item.Provider]++;
            }
            else
            {
                ResArray[item.Provider] = 1;
            }
        }
        foreach (var pair in ResArray)
        {
            Console.WriteLine($"Элемент: {pair.Key}, Количество: {pair.Value}");
        }
    }
}