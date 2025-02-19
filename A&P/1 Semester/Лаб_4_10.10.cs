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

            //дан массив из n положительных целых элементов определить кол-во элементов, все цифры которых четные
            int n = 1, elem, cnt = 0, res = 0, temp;
            bool flag = true;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                elem = Convert.ToInt32(Console.ReadLine());
                arr[i] = elem;
            }
            foreach (var item in arr)
            {
                temp = item;
                while (temp != 0)
                {
                    res = Math.Abs(temp % 10);
                    temp = temp / 10;
                    if (res % 2 != 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    cnt++;
                    res = 0;
                }
                else
                {
                    flag = true;
                }
            }
            Console.WriteLine($"{cnt}");


            // Заменить все четные элементы на 0, нечетные - на 1
            int n2 = 1, elem2;
            n2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                elem2 = Convert.ToInt32(Console.ReadLine());
                arr2[i] = elem2;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] % 2 == 0)
                {
                    arr2[i] = 0;
                }
                else
                {
                    arr2[i] = 1;
                }
            }
            foreach (int i in arr2)
            {
                Console.Write($"{i} ");
            }

            //сформировать выходной массив, в который необходимо сначала положить все четные элементы, а потом нечетные
            int n3 = 1, elem3, cntNum = 0;
            n3 = Convert.ToInt32(Console.ReadLine());
            int[] arr3 = new int[n3];
            int[] arrNew = new int[n3];
            int ChetIndex = 0, neChetIndex = arr3.Length - 1;
            for (int i = 0; i < n3; i++)
            {
                elem3 = Convert.ToInt32(Console.ReadLine());
                arr3[i] = elem3;
            }
            foreach (int number in arr3)
            {
                if (number % 2 == 0)
                {
                    arrNew[ChetIndex] = number;
                    ChetIndex++;
                }
                else
                {
                    arrNew[neChetIndex] = number;
                    neChetIndex--;
                }
            }
            foreach (int i in arr3)
            {
                Console.Write($"{i} ");
            }
        }

    }
    }

