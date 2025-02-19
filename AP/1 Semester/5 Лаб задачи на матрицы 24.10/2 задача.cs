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
            //определить номера пар строк, состоящих из одинаковых элементов
            int n = 1, m = 1, elem, rowCnt = 0, nullCnt = 0, rowPr = 1;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int[] infRow = new int[n * 3];
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
            for (int i = 0; i < (n); i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rowCnt += matrix[i, j];
                    rowPr *= matrix[i, j];
                    if (matrix[i, j] == 0) { nullCnt++; }
                }
                infRow[i * 3] = rowCnt;
                infRow[(i * 3) + 1] = rowPr;
                infRow[(i * 3) + 2] = nullCnt;
                rowCnt = 0;
                rowPr = 1;
                nullCnt = 0;
            }

            for (int i = 2; i <= infRow.Length - 2; i += 3)
            {
                for (int j = i + 1; j <= infRow.Length - 3; j++)
                {
                    if (infRow[i - 2] == infRow[j] && infRow[i - 1] == infRow[j + 1] && infRow[i] == infRow[j + 2])
                    {
                        Console.WriteLine($"Строка {i / 3} = строке {j / 3}");
                    }
                }
            }
        }
    }
}

