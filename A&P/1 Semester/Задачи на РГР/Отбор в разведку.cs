using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tect2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // проверка сразу на всех тестах
            for (int i = 1; i < 11; i++)
            {
                StreamReader sr;
                if (i >= 10) { sr = new StreamReader($"C:\\Users\\рр\\Desktop\\Олимпиадки\\разведка\\input_s1_{Convert.ToString(i)}.txt"); }
                else { sr = new StreamReader($"C:\\Users\\рр\\Desktop\\Олимпиадки\\разведка\\input_s1_0{Convert.ToString(i)}.txt"); }

                int num = Convert.ToInt32(sr.ReadLine());
                int groups = GroupCount(num);
                Console.WriteLine($"Тест {i}  res {groups}");
            }
        }
        static int GroupCount(int n)
        {
            if (n <= 3)
            {
                if (n == 3) { return 1; } else { return 0; }
            }
            else
            {
                int chetCount = n / 2;
                int nechetCount;
                if (n % 2 == 0) { nechetCount = chetCount; }
                else { nechetCount = chetCount + 1; }
                return GroupCount(chetCount) + GroupCount(nechetCount);
            }
        }
    }
}
