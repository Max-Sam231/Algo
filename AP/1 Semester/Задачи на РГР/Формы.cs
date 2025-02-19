using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tect2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // не рекомендуется проверять на тестах где больше 100 форм, очень долго выполняется
            //время
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // считывание файла
            StreamReader sr = new StreamReader("C:\\Users\\рр\\Desktop\\Олимпиадки\\Фомочки\\input19.txt");
            int n = Convert.ToInt32(sr.ReadLine());
            string[] figArr = new string[n];
            string[] tempArr = new string[n * 2];
            bool flag = false;
            // считывание шаблонов фигур
            for (int i = 0; i < n; i++)
            {
                string line = sr.ReadLine().Replace(" ", "");
                figArr[i] = line;
            }
            // считывание форм
            for (int i = n; i < (n * 3); i++)
            {
                string line = sr.ReadLine();
                tempArr[i - n] = line;
            }
            string[] resArr = new string[n * 2];



            for (int i = 0; i < figArr.Length; i++)
            {
                string[] RotateFArr = RotateF(figArr[i]);
                for (int j = 0; j < tempArr.Length; j++)
                {
                    string up1 = tempArr[j].Replace(" ", "").Substring(0, 5);
                    string down1 = tempArr[j].Replace(" ", "").Substring(10, 5);
                    string otherSide1 = tempArr[j].Replace(" ", "").Substring(5, 5);
                    string up1R = new string(up1.Reverse().ToArray());
                    string down1R = new string(down1.Reverse().ToArray());
                    string otherSide1R = new string(otherSide1.Reverse().ToArray());
                    for (int k = j + 1; k <= tempArr.Length - 1; k++)
                    {
                        string up2 = tempArr[k].Replace(" ", "").Substring(0, 5);
                        string down2 = tempArr[k].Replace(" ", "").Substring(10, 5);
                        string otherSide2 = tempArr[k].Replace(" ", "").Substring(5, 5);
                        string up2R = new string(up2.Reverse().ToArray());
                        string down2R = new string(down2.Reverse().ToArray());
                        string otherSide2R = new string(otherSide2.Reverse().ToArray());

                        string tempRes6 = up1 + otherSide2R + down1 + otherSide1; //
                        string tempRes11 = down1 + otherSide1 + up1 + otherSide2R; //

                        string tempRes21 = up1R + otherSide1R + down1R + otherSide2;//
                        string tempRes28 = down1R + otherSide2 + up1R + otherSide1R;//

                        string tempRes29 = up1R + otherSide1R + down1R + otherSide2R; //
                        string tempRes32 = down1R + otherSide2R + up1R + otherSide1R; //

                        if (CheckF(RotateFArr, tempRes6))
                        {
                            Console.WriteLine($"6 {i + 1}: {j + 1} {k + 1} {tempRes6}");
                            flag = true; break;
                        }
                        else if (CheckF(RotateFArr, tempRes11))
                        {
                            Console.WriteLine($"11 {i + 1}: {j + 1} {k + 1} {tempRes11}");
                            flag = true; break;
                        }
                        else if (CheckF(RotateFArr, tempRes21))
                        {
                            Console.WriteLine($"21 {i + 1}: {j + 1} {k + 1} {tempRes21}");
                            flag = true; break;
                        }
                        else if (CheckF(RotateFArr, tempRes28))
                        {
                            Console.WriteLine($"28 {i + 1}: {j + 1} {k + 1} {tempRes28}");
                            flag = true; break;
                        }
                        else if (CheckF(RotateFArr, tempRes29))
                        {
                            Console.WriteLine($"29 {i + 1}: {j + 1} {k + 1} {tempRes29}");
                            flag = true; break;
                        }
                        else if (CheckF(RotateFArr, tempRes32))
                        {
                            Console.WriteLine($"32 {i + 1}: {j + 1} {k + 1} {tempRes32}");
                            flag = true; break;
                        }
                    }
                    if (flag)
                    {
                        flag = false;
                        break;
                    }
                }
            }


            Console.WriteLine();
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
            //Console.WriteLine($"Время выполнения: {stopwatch.Elapsed.TotalSeconds} секунд");
        }

        static string[] RotateF(string input)
        {
            string[] tempArr = new string[4];
            for (int i = 0; i < 4; i++)
            {
                string firstFive = input.Substring(0, 5);
                string remaining = input.Substring(5);
                input = remaining + firstFive;
                tempArr[i] = input;
            }
            return tempArr;
        }
        static bool CheckF(string[] array, string temp)
        {
            if (array[0] == temp || array[1] == temp || array[2] == temp || array[3] == temp)
            {
                return true;
            }
            else { return false; }

        }
    }
}