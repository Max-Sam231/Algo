using System;
using System.Collections.Generic;
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
            //Дана последовательность из n  элементов
            // 1 задача
            // Послед. n Определить кол-во элементов с чётной суммой цифры массивы нет строки нет
            int cur, n = 0, cnt = 0, res;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                cur = Convert.ToInt32(Console.ReadLine());
                res = 0;
                while (cur != 0)
                {
                    res += Math.Abs(cur % 10);
                    cur = cur / 10;
                }
                if (res % 2 == 0)
                {
                    cnt++;
                }
            }
            Console.WriteLine($"Результат {cnt}");
            // 2 задача
            // Послед. n определить кол-во элементов у которых кол-во четных цифр больше нечетных строки нет
            int cur2, n2 = 0, chet = 0, nechet = 0, res2 = 0, cnt2 = 0;
            n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                cur2 = Convert.ToInt32(Console.ReadLine());
                while (cur2 != 0)
                {
                    res2 += Math.Abs(cur2 % 10);
                    cur2 = cur2 / 10;
                    if (res2 % 2 == 0)
                    {
                        chet++;
                    }
                    else
                    {
                        nechet++;
                    }
                    res2 = 0;
                }
                if (chet > nechet)
                {
                    cnt2++;
                }
                chet = 0;
                nechet = 0;
            }
            Console.WriteLine($"Результат {cnt2}");

        }
    }
}

