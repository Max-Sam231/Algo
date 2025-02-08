using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace tect
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // на вход подается набор строк окончание пустая строка
            //1 определить количество строк которых присутствует сочетания а*б где *-любой символ

            //1
            string n = Console.ReadLine().ToLower();
            int cnt = 0;
            while (n != "")
            {
                for (int i = 0; i < n.Length - 2; i++)
                {
                    if (n[i] == 'a' && n[i + 2] == 'b')
                    {
                        cnt++;
                    }
                }
                Console.WriteLine(cnt);
                cnt = 0;
                n = Console.ReadLine();
            }

            //2 определить максимальныю длину каждой подстроки состоящей из abc при этом что-то отсутствует
            //2
            string n2 = Console.ReadLine();
            int outmax = 0;
            while (n2 != "")
            {
                n2 = n2.ToLower();
                string temp = "a";
                int maxlen = 0;

                while (n2.Contains(temp))
                {
                    maxlen++;
                    int len = temp.Length + 1;
                    if (len % 3 == 1)
                    {
                        temp += "a";
                    }
                    else if (len % 3 == 2)
                    {
                        temp += "b";
                    }
                    else { temp += "c"; }
                }
                outmax = Math.Max(outmax, maxlen);
                Console.WriteLine(outmax);
                n2 = Console.ReadLine();
                temp = "a";
                outmax = 0;
                maxlen = 0;
            }

        }
    }
}
