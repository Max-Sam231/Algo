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
            // минимальный в строке максимальный в столбце
            int n = 1, m = 1, elem;
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
             int[] minRow = new int[n];
             int[] maxRow = new int[n];
             for (int i = 0; i < n; i++) { minRow[i] = matrix[i, 0]; }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     minRow[i] = Math.Min(matrix[i, j], minRow[i]);
                     maxRow[i] = Math.Max(matrix[i, j], maxRow[i]);
                 }
             }
            int[] maxCol = new int[m];
            int[] minCol = new int[m];
            for (int j = 0; j < m; j++) { minCol[j] = matrix[0, j]; }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    maxCol[j] = Math.Max(matrix[i, j], maxCol[j]);
                    minCol[j] = Math.Min(matrix[i, j], minCol[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == maxCol[j] && matrix[i, j] == minRow[i])
                    { Console.WriteLine($"Минимальный в строке и максимальный в столбце {matrix[i, j]}"); }
                    if (matrix[i, j] == minCol[j] && matrix[i, j] == maxRow[i])
                    { Console.WriteLine($"Максимальный в строке и минимальный в столбце {matrix[i, j]}"); }
                }
            }
        }
    }
}

