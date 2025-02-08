using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 начало
            //отсортировать столбцы массива по возрастанию их сумм
            int n = 1, m = 1, elem, tempCnt = 0;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < m; j++)
                {
                    elem = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = elem;
                }
            }
            // Вывод
            Console.WriteLine("Иcходная матрица");
            for (int i = 0; i < n; i++) // Цикл по строкам
            {
                for (int j = 0; j < m; j++) // Цикл по столбцам
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Сам алгоритм
            for (int j = 0; j < m - 1; j++)
            {
                int minIndex = j;
                for (int k = j + 1; k < m; k++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (matrix[i, k] != matrix[i, minIndex])
                        {
                            tempCnt = matrix[i, k] - matrix[i, minIndex];
                        }
                    }
                    if (tempCnt < 0)
                    {
                        minIndex = k;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, minIndex];
                    matrix[i, minIndex] = temp;
                }
            }
            // Вывод
            Console.WriteLine("Конечеая матрица");
            for (int i = 0; i < n; i++) // Цикл по строкам
            {
                for (int j = 0; j < m; j++) // Цикл по столбцам
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

