using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 задача
            int prev,cur,next,n,cnt=0;
            n = Convert.ToInt32(Console.ReadLine());
            prev = Convert.ToInt32(Console.ReadLine());
            cur = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < n; i++) {
                next = Convert.ToInt32(Console.ReadLine());
                if (cur < prev && cur < next) { cnt++; }
                prev = cur;
                cur = next;

            }
            Console.WriteLine($"кол-во {cnt}");
            // 2 задача
            int a, count;
            bool flag = true;
            count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 != 0)
                {
                    flag = false;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Нет");
            }
            else
            {
                Console.WriteLine("Да");
            }
            //3 задача
            int b, countN, mx1 = 0, mx2 = 0;
            countN = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b > mx1)
                {
                    mx2 = mx1;
                    mx1 = b;
                }
                else if (b > mx2)
                {
                    mx2 = b;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"первый максимум {mx1} второй максимум {mx2}");

        }
    }
}

