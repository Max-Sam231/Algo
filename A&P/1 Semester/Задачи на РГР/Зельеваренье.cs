using System;
using System.Collections.Generic;
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
            StreamReader sr = new StreamReader("C:\\Users\\рр\\Desktop\\Олимпиадки\\done зелье\\input10.txt");
            int count = System.IO.File.ReadAllLines($"C:\\Users\\рр\\Desktop\\Олимпиадки\\done зелье\\input10.txt").Length;
            string[] lineArr = new string[count];
            string line = sr.ReadLine();
            lineArr[0] = line;

            for (int i = 1; i < count; i++)
            {
                line = sr.ReadLine();
                lineArr[i] = line;
            }
            string[] resArr = new string[count + 1];
            for (int i = 0; i < count; i++)
            {
                string[] elemArr = lineArr[i].Split(' ');
                MatchCollection matches = Regex.Matches(lineArr[i], @"\d+");
                if (matches.Count == 0)
                {
                    if (elemArr[0] == "DUST") { elemArr[0] = ""; resArr[i + 1] = $"DT{string.Join("", elemArr)}TD"; }
                    if (elemArr[0] == "WATER") { elemArr[0] = ""; resArr[i + 1] = $"WT{string.Join("", elemArr)}TW"; }
                    if (elemArr[0] == "FIRE") { elemArr[0] = ""; resArr[i + 1] = $"FR{string.Join("", elemArr)}RF"; }
                    if (elemArr[0] == "MIX") { elemArr[0] = ""; resArr[i + 1] = $"MX{string.Join("", elemArr)}XM"; }
                }
                else
                {
                    if (elemArr[0] == "WATER") { elemArr[0] = ""; resArr[i + 1] = $"WT{string.Join(",", elemArr)}TW"; ReplaceNum(resArr[i + 1], resArr, i + 1); }
                    if (elemArr[0] == "DUST") { elemArr[0] = ""; resArr[i + 1] = $"DT{string.Join(",", elemArr)}TD"; ReplaceNum(resArr[i + 1], resArr, i + 1); }
                    if (elemArr[0] == "FIRE") { elemArr[0] = ""; resArr[i + 1] = $"FR{string.Join(",", elemArr)}RF"; ReplaceNum(resArr[i + 1], resArr, i + 1); }
                    if (elemArr[0] == "MIX") { elemArr[0] = ""; resArr[i + 1] = $"MX{string.Join(",", elemArr)}XM"; ReplaceNum(resArr[i + 1], resArr, i + 1); }

                }
            }
            // ответ
            StreamReader an = new StreamReader("C:\\Users\\рр\\Desktop\\Олимпиадки\\зелье\\output10.txt");
            string answer = an.ReadLine();
            if (answer == resArr[resArr.Length - 1].Replace(",", "")) { Console.WriteLine("ВЕРНО"); }
        }
        public static void ReplaceNum(string inputString, string[] Arr, int n)
        {
            Arr[n] = Regex.Replace(inputString, @"\d+", match =>
            {
                int digit = int.Parse(match.Value);
                //Console.WriteLine(digit);
                return Arr[digit].Replace(",", "");
            });
        }
    }
}
