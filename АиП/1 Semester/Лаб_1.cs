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
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a} b={b}");

            int c, d;
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            c = (c + d + Math.Abs(c - d)) / 2;
            Console.WriteLine($"Максимум={c}");

            int p, m, l, n, res;
            p = 5;
            m = 3;
            l = 3;
            n = Convert.ToInt32(Console.ReadLine());
            res = (p + m * 2 + l * 2 + l * (n - 1) + p) * n;
            Console.WriteLine($"Расстояние={res}");
        }
    }
}
