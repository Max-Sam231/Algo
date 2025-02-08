using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace tect
{
    public class Train
    {
        public string NumTrain { get; set; }
        public string NameDestination { get; set; }
        public string NameOrigin { get; set; }
        public string Time{ get; set; }

        public Train(string numTrain, string destination, string origin, string time)
        {
            NumTrain = numTrain;
            NameDestination = destination;
            NameOrigin = origin;
            Time = time;
        }
    }

    public class Station
    {
        public string StationName { get; set; }
        public Train[] Trains { get; set; }
        public int TrainCapacity { get; set; }
        public Station(string stationName, int trainCapacity)
        {
            StationName = stationName;
            TrainCapacity = trainCapacity;
            Trains = new Train[trainCapacity];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Station stat1 = new Station("aaa",3);
            bool flag = false;

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввод данных");
                Console.WriteLine("2. Вывод информации о поездах по назначению");
                Console.WriteLine("3. Вывод данных о поездах по отправлению");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTrains(stat1);
                        flag = true;
                        break;
                    case "2":
                        if (flag)
                        {
                            Console.Write("Введите пункт отправления: ");
                            string userOrigin = Console.ReadLine();
                            GetTrainsOrigin(stat1, userOrigin);
                        }
                        else { Console.WriteLine("Нет добавленных поездов"); }

                        break;
                    case "3":
                        if (flag)
                        {
                        Console.Write("Введите пункт отправления: ");
                        string userDestination = Console.ReadLine();
                        GetTrainsDestination(stat1, userDestination);
                        }
                        else { Console.WriteLine("Нет добавленных поездов"); }
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }

         
        
        }
        private static void AddTrains(Station stat)
        {
            for (int i = 0; i < stat.TrainCapacity; i++)
            {
                Console.Write("Введите номер поезда: ");
                string numTrain = Console.ReadLine();
                Console.Write("Введите название пункта назначения: ");
                string destination = Console.ReadLine();
                Console.Write("Введите название пункта отправления: ");
                string origin = Console.ReadLine();
                Console.Write("Введите время отправления: ");
                string time = Console.ReadLine();

                Train train = new Train(numTrain, destination, origin, time);
                stat.Trains[i] = train;
                Console.WriteLine("Данные о поезде успешно добавлены.");  
            }
        }

        private static void GetTrainsOrigin(Station stat, string nameOrigin)
        {
                foreach (Train train in stat.Trains)
                {
                    if (train.NameOrigin == nameOrigin)
                    {
                        Console.WriteLine($"Номер поезда: {train.NumTrain}, Место отправления поезда: {train.NameOrigin}, Место назначения поезда: {train.NameDestination}, Время отправления: {train.Time}");
                    }
                }
           

        }
        private static void GetTrainsDestination(Station stat, string nameDestination)
        {

            foreach (Train train in stat.Trains)
            {
                if (train.NameDestination == nameDestination)
                {
                    Console.WriteLine($"Номер поезда: {train.NumTrain}, Место отправления поезда: {train.NameOrigin}, Место назначения поезда: {train.NameDestination}, Время отправления: {train.Time}");
                }
            }
            
        }

    }
}
