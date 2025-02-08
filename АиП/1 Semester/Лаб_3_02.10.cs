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

            // 1 задача определить макс подпоследовательность четных элементов
            int prev, cur, n, cnt = 1, mx = 1;
            n = Convert.ToInt32(Console.ReadLine());
            prev = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                cur = Convert.ToInt32(Console.ReadLine());
                if (prev % 2 == 0 && cur % 2 == 0)
                {
                     cnt += 1;
                     if (cnt > mx) { mx = cnt; }
                }
                else
                {
                    cnt = 1;
                    prev = cur;
                }
            }
            Console.WriteLine($"Максимум {mx}");

            // 2 задача максимальную длину из одинаковых элементов
            int prev2, cur2, n2, cnt2 = 1, mx2 = 1;
            n2 = Convert.ToInt32(Console.ReadLine());
            prev2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n2; i++)
            {
                cur2 = Convert.ToInt32(Console.ReadLine());
                if (prev2 == cur2)
                {
                    cnt2 += 1;
                    if (cnt2 > mx2)
                    {
                    mx2 = cnt2;
                    }
                }
                else
                {
                    cnt2 = 1;
                    prev2 = cur2;
                }
            }
            Console.WriteLine($"Максимум {mx2}");


            // 3 задача определить длину подпоследовательности из чётных элементов с наибольший суммой элементов и вывести длину подпоследовательности
            int cur, curLen = 0, n;
            n = Convert.ToInt32(Console.ReadLine());
            int mnLen = n + 1;
            for (int i = 0; i < n; i++)
            {
                cur = Convert.ToInt32(Console.ReadLine());
                if (cur % 2 == 0) {curLen++;}
                else
                {
                    if (curLen > 0)
                    {mnLen = Math.Min(curLen, mnLen);}
                    curLen = 0;
                }
            }
            if (curLen > 0)
            {mnLen = Math.Min(curLen, mnLen);}
            
            if (mnLen == n + 1)
            {
                Console.WriteLine("Четных элементов в последовательности нет.");
            }
            else
            {
                Console.WriteLine($"Минимальная длина подпоследовательности из четных элементов: {mnLen}");
            }
        }
    }
}

