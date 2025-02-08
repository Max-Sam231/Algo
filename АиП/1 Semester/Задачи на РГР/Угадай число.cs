using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Считывание
            StreamReader sr = new StreamReader("C:\\Users\\рр\\Desktop\\Олимпиадки\\done угадай число\\input_s1_09.txt");
            int count = System.IO.File.ReadAllLines("C:\\Users\\рр\\Desktop\\Олимпиадки\\done угадай число\\input_s1_09.txt").Length;
            string[] lineArr = new string[count];
            string line = sr.ReadLine();
            lineArr[0] = Convert.ToString('x');
            for (int i = 1; i < count; i++)
            { 
                line = sr.ReadLine();
                lineArr[i] = line;
            }
            //Console.WriteLine("[{0}]", string.Join(", ", lineArr));

            int num;
            int cntX = 1;
            int numRes = 0;

            for (int i = 1; i < count - 1; i++)
            {
                char oper = Convert.ToChar(lineArr[i].Split(' ')[0]);
                string temp = lineArr[i].Split(' ')[1];
                if (temp != "x")
                {
                    num = Convert.ToInt32(temp);
                    if (oper == '+') { numRes += num; }
                    if (oper == '*') { numRes *= num; cntX *= num; }
                    if (oper == '-') { numRes -= num; }
                }
                else
                {
                    if (oper == '+') { cntX += 1; }
                    if (oper == '-') { cntX -= 1; }
                }

            }
            //Console.WriteLine(numRes);
            //Console.WriteLine(cntX);

            int res = (Convert.ToInt32(lineArr[lineArr.Length - 1]) - numRes) / cntX;
            Console.WriteLine($"Результат {res}");
        }
    }
}
