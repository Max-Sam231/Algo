using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace tect2
{
    internal class Program
    {
        public class Animal
        {
            public string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }
        }
        public class Birds : Animal
        {
            public string Habitat { get; set; } 
            public string WinteringPlace { get; set; } 

            public Birds(string name, string habitat, string winteringPlace) : base(name)
            {
                Habitat = habitat;
                WinteringPlace = winteringPlace;
            }
        }
        public class Mammals : Animal
        {
            public string Habitat { get; set; } 
            public int Weight { get; set; } 

            public Mammals(string name, string habitat, int weight) : base(name)
            {
                Habitat = habitat;
                Weight = weight;
            }
        }


        static void Main(string[] args)
        {
            bool flagMammals = false;
            bool flagBirds = false;
            Mammals[] mammalsArr = new Mammals[3];
            Birds[] birdsArr = new Birds[3];
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввод данных о птицах");
                Console.WriteLine("2. Ввод данных о млекапитающих");
                Console.WriteLine("3. Поиск животных по месту обитания");
                Console.WriteLine("4. Поиск птиц по месту обитания");
                Console.WriteLine("5. Поиск животных по весу");
                Console.WriteLine("6. Поиск птиц по месту зимования");
                Console.WriteLine("7. Выход");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBirds(birdsArr);
                        flagBirds = true;
                        break;
                    case "2":
                        AddMammals(mammalsArr);
                        flagMammals = true;
                        break;
                    case "3":
                        if (flagMammals){
                            Console.Write("Введите место обитания: ");
                            string userHabitat = Console.ReadLine();
                            MammalsHabitat(mammalsArr, userHabitat);
                        }
                        else { Console.WriteLine("Нет добавленных животных"); }
                        break;
                    case "4":
                        if (flagBirds)
                        {
                            Console.Write("Введите место обитания: ");
                            string userHabitat= Console.ReadLine();
                            BirdsHabitat(birdsArr, userHabitat);
                        }
                        else { Console.WriteLine("Нет добавленных птиц"); }
                        break;
                    case "5":
                        if (flagMammals)
                        {
                            Console.Write("Введите вес: ");
                            string userWeight = Console.ReadLine();
                            MammalsWeight(mammalsArr, userWeight);
                        }
                        else { Console.WriteLine("Нет добавленных животных"); }
                        break;
                    case "6":
                        if (flagBirds)
                        {
                            Console.Write("Введите место зимования: ");
                            string userWinteringPlace = Console.ReadLine();
                            BirdsWinteringPlace(birdsArr, userWinteringPlace);
                        }
                        else { Console.WriteLine("Нет добавленных птиц"); }
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }


        }
        private static void AddMammals(Mammals[] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите имя животного: ");
                string name = Console.ReadLine();
                Console.Write("Введите место обитания: ");
                string habitat = Console.ReadLine();
                Console.Write("Введите вес: ");
                int weight = Convert.ToInt32(Console.ReadLine());
                Mammals mammals = new Mammals(name, habitat, weight);
                arr[i] = mammals;
                Console.WriteLine("Данные о животном успешно добавлены.");
            }
        }
        private static void AddBirds(Birds[] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите имя птицы: ");
                string name = Console.ReadLine();
                Console.Write("Введите место обитания: ");
                string habitat = Console.ReadLine();
                Console.Write("Введите место зимования: ");
                string winteringPlace = Console.ReadLine();
                Birds bird = new Birds(name, habitat, winteringPlace);
                arr[i] = bird;
                Console.WriteLine("Данные о птице успешно добавлены.");
            }
        }
        private static void MammalsHabitat(Mammals[] arr, string habitat)
        {
            foreach (Mammals mammal in arr)
            {
                if (mammal.Habitat == habitat)
                {
                    Console.WriteLine($"Имя {mammal.Name}");
                }
            }
        }
        private static void MammalsWeight(Mammals[] arr, string weight)
        {
            foreach (Mammals mammal in arr)
            {
                if (mammal.Weight == Convert.ToInt32(weight))
                {
                    Console.WriteLine($"Имя {mammal.Name}");
                }
            }
        }
        private static void BirdsHabitat(Birds[] arr, string habitat)
        {
            foreach (Birds bird in arr)
            {
                if (bird.Habitat == habitat)
                {
                    Console.WriteLine($"Имя {bird.Name}");
                }
            }
        }
        private static void BirdsWinteringPlace(Birds[] arr, string winteringPlace)
        {
            foreach (Birds bird in arr)
            {
                if (bird.WinteringPlace == winteringPlace)
                {
                    Console.WriteLine($"Имя {bird.Name}");
                }
            }
        }


    }
}