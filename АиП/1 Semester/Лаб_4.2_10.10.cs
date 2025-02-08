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
            //на вход подается последовательность положительность целых элементов.
            //признак окончания последовательности не положительный элемент
            //каждый элемент последовательность преобразовать следующим образом
            //изменить порядок представления числа на обратный удалив все четные цифры
            //в том случае если в числе нет нечетных цифр выдать сообщение

            int cur, i = 1, n = 1, curNum, res = 0;
            while (n > 0)
            {
                cur = Convert.ToInt32(Console.ReadLine());
                if (cur <= 0) {break;}
                i = cur;
                while (cur != 0)
                {
                    curNum = Math.Abs(cur % 10);
                    cur = cur / 10;
                    if (curNum % 2 != 0)
                    {
                        res = res * 10 + curNum;
                    }
                }
                if (res == 0)
                {
                    Console.WriteLine("Нет нечетных цифр");
                }
                else
                {
                    Console.WriteLine(res);
                }
                res = 0;
                n = i;
            }

        }

    }
    }

