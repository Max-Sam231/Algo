//Создается телефонный справочник, при этом у абонентов может быть несколько различных номеров телефонов,
//подключенных к различным операторам связи в определенный год. ФИО, номер, оператор, год подключения, город.
//Необходимо написать программу которая реализует меню 
//по заполнению базы телефонного справочника,
//по выборке данных конкретного оператора связи, 
//по выборке по году подключения,
//выборка по номеру телефона. 
//Функция выхода.

internal class Program
{
    public class Subscriber
    {
        public string Name { get; set; }
        public Phone[] Phones { get; set; }
        public string City { get; set; }

        public Subscriber(string name, Phone[] phones, string city)
        {
            Name = name;
            Phones = phones;
            City = city;
        }
    }

    public class Phone
    {
        public string PhoneNumber { get; set; }
        public string Provider { get; set; }
        public string YearConnect { get; set; }

        public Phone(string phoneNumber, string provider, string yearConnect)
        {
            PhoneNumber = phoneNumber;
            Provider = provider;
            YearConnect = yearConnect;

        }
    }

    static void Main(string[] args)
    {
        bool flagSubscriber = false;
        Subscriber[] subscriberArr = new Subscriber[2]; ;
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Ввод данных о абоненте");
            Console.WriteLine("2. Поиск абонента по номеру телефона");
            Console.WriteLine("3. Поиск абонента по оператору");
            Console.WriteLine("4. Поиск абонента по году подключения");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите действие: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddSubscriber(subscriberArr);
                    flagSubscriber = true;
                    break;
                case "2":
                    if (flagSubscriber)
                    {
                        Console.Write("Введите номер телефона: ");
                        string userReq = Console.ReadLine();
                        SearchSubscriber(subscriberArr, userReq, "phoneNum");
                    }
                    else { Console.WriteLine("Нет добавленных абонентов"); }
                    break;
                case "3":
                    if (flagSubscriber)
                    {
                        Console.Write("Введите оператора: ");
                        string userReq = Console.ReadLine();
                        SearchSubscriber(subscriberArr, userReq, "provider");
                    }
                    else { Console.WriteLine("Нет добавленных абонентов"); }
                    break;
                case "4":
                    if (flagSubscriber)
                    {
                        Console.Write("Введите год подключения: ");
                        string userReq = Console.ReadLine();
                        SearchSubscriber(subscriberArr, userReq, "year");
                    }
                    else { Console.WriteLine("Нет добавленных абонентов"); }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }


    }
    private static void AddSubscriber(Subscriber[] arr)
    {
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Введите имя абонента: ");
            string name = Console.ReadLine();
            Console.Write("Введите место проживания абонента: ");
            string city = Console.ReadLine();
            Console.Write("Введите количество номеров абонента: ");
            int phoneCount = Convert.ToInt32(Console.ReadLine());
            Phone[] phoneArray = new Phone[phoneCount];
            for (int j = 0; j < phoneCount; j++)
            {
                Console.Write("Введите номер телефона: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Введите оператора связи: ");
                string provider = Console.ReadLine();
                Console.Write("Введите год регистрации номера: ");
                string year = Console.ReadLine();
                Phone phone = new Phone(phoneNumber, provider, year);
                phoneArray[j] = phone;
                Console.WriteLine("Номер успешно добавлен.");

            }
            Subscriber subscriber = new Subscriber(name, phoneArray, city);
            arr[i] = subscriber;
            Console.WriteLine("Данные о абоненте успешно добавлены.");
        }
    }
    private static void SearchSubscriber(Subscriber[] arr, string req, string searchType)
    {
        foreach (Subscriber sub in arr)
        {
            foreach (Phone item in sub.Phones)
            {
                switch (searchType)
                {
                    case "phoneNum":
                        if (item.PhoneNumber == req)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"ФИО: {sub.Name}");
                        }
                        break;
                    case "provider":
                        if (item.Provider == req)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"ФИО: {sub.Name}");

                        }
                        break;
                    case "year":
                        if (item.YearConnect == req)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"ФИО: {sub.Name}");
                        }
                        break;
                }
            }
        }
    }

}
