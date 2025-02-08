Лаба за 27.11

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

// Создается класс, где две переменных целого типа. Конструкторы следующие: 
// 1. Конструктор без аргументов.
// 2. Конструктор, который принимает 1 аргумент для инициализации.
// 3. Конструктор, который принимает 2 аргумента для инициализации.
// Если конструктор без аргументов - проинициализировать нулями.
// Если 1 аргумент, то второе значение проинициализировать нулем.
// Записать 4 метода:
// 1. Суммирование двух переменных класса
// 2. Произведение двух переменных класса
// 3. Разность двух переменных класса
// 4. Деление первого аргумента на второй. Проверить деление на ноль
// Без свойств
        
        public class SnowClass
        {
            private int num1;
            private int num2;

            public SnowClass()
            {
                num1 = 0;
                num2 = 0;
            }

            public SnowClass(int n1)
            {
                num1 = n1;
                num2 = 0;
            }

            public SnowClass(int n1, int n2)
            {
                num1 = n1;
                num2 = n2;
            }
            public int Sum()
            {
                return num1 + num2;
            }

            public int Multiply()
            {
                return num1 * num2;
            }

            public int Substract()
            {
                return num1 - num2;
            }

            public double Del()
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Попытка деления на ноль.");
                    return Double.NaN;
                }
                else
                {
                    return (double)num1 / num2;
                }
            }

        }
        static void Main(string[] args)
        {
            SnowClass obj1 = new SnowClass();  // Вызов конструктора без аргументов
            SnowClass obj2 = new SnowClass(5);  // Вызов конструктора с 1 аргументом
            SnowClass obj3 = new SnowClass(3, 7);  // Вызов конструктора с 2 аргументами
            Console.WriteLine("Сумма: " + obj1.Sum());
            Console.WriteLine("Произведение: " + obj1.Multiply());
            Console.WriteLine("Разность: " + obj1.Substract());
            Console.WriteLine("Деление: " + obj1.Del());

            Console.WriteLine("Сумма: " + obj2.Sum());
            Console.WriteLine("Произведение: " + obj2.Multiply());
            Console.WriteLine("Разность: " + obj2.Substract());
            Console.WriteLine("Деление: " + obj2.Del());

            Console.WriteLine("Сумма: " + obj3.Sum());
            Console.WriteLine("Произведение: " + obj3.Multiply());
            Console.WriteLine("Разность: " + obj3.Substract());
            Console.WriteLine("Деление: " + obj3.Del());
        }
    }
}
