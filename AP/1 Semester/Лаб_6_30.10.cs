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
            int n = 1, elem;
            int chet = 0, nechet = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[][] matrix = new int[4][]; 
            for (int i = 0; i < matrix.Length; i++) {matrix[i] = new int[n];}
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    elem = Convert.ToInt32(Console.ReadLine());
                    matrix[i][j] = elem;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("[{0}]", string.Join(",", matrix[i]));
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] % 2 == 0)  {chet++;} else {nechet++;}
                }
                Console.WriteLine($"Строка {i} нечетных {nechet} , четных {chet}");
                chet= 0;    
                nechet= 0;
            }
            int tempCnt = matrix[0][0];
            int pos = 0;
            int sumElem = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumElem += matrix[i][j];
                    if (tempCnt < matrix[i][j])
                    {
                        tempCnt = matrix[i][j];
                        pos = j;
                    }
                }
                    sumElem -= tempCnt;
                    if (tempCnt > sumElem) { Console.WriteLine($"Позиция элемента большего суммы других {pos}"); }
                    else { Console.WriteLine("Нет такого элемента"); }
                    sumElem = 0; tempCnt = 0; pos = 0;

            }
        }
    }
}

