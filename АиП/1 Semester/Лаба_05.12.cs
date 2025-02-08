using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace tect
{
    public class Student
    {
        public string FullName { get; set; }
        public int BirthYear { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }

        public Student(string fullName, int birthYear, string motherName, string fatherName, string address)
        {
            FullName = fullName;
            BirthYear = birthYear;
            MotherName = motherName;
            FatherName = fatherName;
            Address = address;
        }
    }
    internal class Program
    {
        static Student[] students = new Student[3];
        static int studentCount = 0;
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Заполнение данных ученика");
                Console.WriteLine("2. Модификация данных ученика");
                Console.WriteLine("3. Поиск учеников, начинающихся на заданный символ");
                Console.WriteLine("4. Поиск учеников, проживающих на заданной улице");
                Console.WriteLine("5. Поиск учеников по году рождения");
                Console.WriteLine("6. Выход");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ModifyStudent();
                        break;
                    case "3":
                        SearchByFirstChar();
                        break;
                    case "4":
                        SearchByStreet();
                        break;
                    case "5":
                        SearchByBirthYear();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

            }
        }

        private static void AddStudent()
        {
            Console.Write("Введите ФИО ученика: ");
            string fullName = Console.ReadLine();
            Console.Write("Введите год рождения ученика: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Введите ФИО мамы (или оставьте пустым): ");
            string motherName = Console.ReadLine();
            Console.Write("Введите ФИО папы (или оставьте пустым): ");
            string fatherName = Console.ReadLine();
            Console.Write("Введите адрес (улица, дом, квартира): ");
            string address = Console.ReadLine();

            students[studentCount] = new Student(fullName, birthYear, motherName, fatherName, address);
            studentCount++;
            Console.WriteLine("Данные ученика успешно добавлены.");
        }
        private static void ModifyStudent()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("Массив пустой. Невозможно модифицировать данные.");
                return;
            }
            Console.Write("Введите ФИО ученика для модификации: ");
            string fullName = Console.ReadLine();
            int index = -1;

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].FullName == fullName)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Ученик с таким ФИО не найден.");
                return;
            }
            Console.Write("Введите новый год рождения ученика: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Введите новое ФИО мамы (или оставьте пустым): ");
            string motherName = Console.ReadLine();
            Console.Write("Введите новое ФИО папы (или оставьте пустым): ");
            string fatherName = Console.ReadLine();
            Console.Write("Введите новый адрес (улица, дом, квартира): ");
            string address = Console.ReadLine();
            students[index].BirthYear = birthYear;
            students[index].MotherName = motherName;
            students[index].FatherName = fatherName;
            students[index].Address = address;
            Console.WriteLine("Данные ученика успешно изменены.");
        }

        private static void SearchByStreet()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("Массив пустой. Невозможно выполнить поиск.");
                return;
            }

            Console.Write("Введите улицу для поиска: ");
            string street = Console.ReadLine();

            Console.WriteLine("Ученики, проживающие на заданной улице:");
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].Address.Contains(street))
                {
                    Console.WriteLine(students[i].FullName);
                }
            }
        }
        private static void SearchByFirstChar()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("Массив пустой. Невозможно выполнить поиск.");
                return;
            }

            Console.Write("Введите символ для поиска: ");
            char firstChar = Console.ReadLine()[0];

            Console.WriteLine("Ученики, начинающиеся на заданный символ:");
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].FullName[0] == firstChar)
                {
                    Console.WriteLine(students[i].FullName);
                }
            }
        }
        private static void SearchByBirthYear()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("Массив пустой. Невозможно выполнить поиск.");
                return;
            }

            Console.Write("Введите год рождения для поиска: ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Ученики, родившиеся в заданном году:");
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].BirthYear == birthYear)
                {
                    Console.WriteLine(students[i].FullName);
                }
            }
        }
    }
}