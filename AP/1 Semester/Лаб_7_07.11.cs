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
            //1 дана строка, необходимо отформатировать ее таким образом, чтобы между словами было ровно по одному пробелу
            string str = Console.ReadLine();
            string mStr = string.Join(" ", str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine(mStr);

            //2 необходимо в строке, состоящей из слов, между которыми по 1 пробелу, выдать все слова-перевертыши (палиндромы)
            string str2 = Console.ReadLine();
            string[] words = str2.Split(' ');
            foreach (string word in words)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    Console.WriteLine(word);
                }
            }

            //3 определить, является ли строка палиндромом
            string str3 = Console.ReadLine();
            string mStr3 = string.Join("", str3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            mStr3 = mStr3.ToLower();
            if (mStr3.SequenceEqual(mStr3.Reverse()))
            {
                Console.WriteLine("Строка палиндром");
            }
            //4 дано n строк, выдать только те строки, в которых кол-во гласных букв больше, чем кол-во согласных (ь, ъ  считать согласными)
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str4 = Console.ReadLine();
                string mStr4 = string.Join("", str4.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                int glCount = 0;
                string gl = "аеёиоуыэюя";
                foreach (char c in mStr4.ToLower())
                {
                    if (gl.Contains(c))
                    {
                        glCount++;
                    }
                }
                int cogCount = 0;
                string cog = "бвгджзйклмнпрстфхцчшщъь";
                foreach (char c in mStr4.ToLower())
                {
                    if (cog.Contains(c))
                    {
                        cogCount++;
                    }
                }
                if (glCount > cogCount) 
                {
                    Console.WriteLine($"Нужная строка {str}");
                }
            }        
    }
    }
}
