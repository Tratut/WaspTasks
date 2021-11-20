using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        static int sumNum(int x)
        {
            int sum = 0;
            while(x != 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
        static bool isAsmallerB(string a, string b)
        {
            char[] masA = new char[a.Length];
            char[] masB = new char[b.Length];
            for(int i=0; i < a.Length; i++)
            {
                masA[i] = Convert.ToChar(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                masB[i] = Convert.ToChar(b[i]);
            }
            for (int i = 0; i < Math.Min(masA.Length, masB.Length); i++)
            {
                if (masA[i] < masB[i]) return true;
                else if (masA[i] > masB[i]) return false;
                else continue;
            }
            if (masA.Length > masB.Length) return false;
            else return true;
        }
        public static List<int> OrderWeight(List<int> list)
        {
            // Здесь необходимо написать код.
            string a, b;
            bool flag = false;
            int swap;
            do
            {
                flag = false;
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] == list[i - 1]) continue;
                    if (sumNum(list[i - 1]) > sumNum(list[i]))
                    {
                        swap = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = swap;
                        flag = true;
                    }
                    else if (sumNum(list[i]) == sumNum(list[i - 1]))
                    {
                        a = Convert.ToString(list[i]);
                        b = Convert.ToString(list[i - 1]);
                        if (isAsmallerB(a, b))
                        {
                            swap = list[i];
                            list[i] = list[i - 1];
                            list[i - 1] = swap;
                            flag = true;
                        }
                    }
                }
            } while (flag);

            return list;
        }
    }
}
