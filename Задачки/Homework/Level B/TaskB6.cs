using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B6.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Reverser, которая меняет порядок букв в каждом слове заданного
    // предложения на противоположный, порядок слов, при этом, должен сохраниться.
    //
    // Пример:
    // Reverser("reverse letters") ==> "esrever srettel".
    public static class TaskB6
    {
        static string rev(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        public static string Reverser(string s)
        {
            // Здесь необходимо написать код.
            string[] mas = s.Split();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rev(mas[i]);
            }
            string res = "";
            for (int k = 0; k < mas.Length; k++)
            {
                if (k < mas.Length - 1)
                    res += mas[k] + " ";
                else res += mas[k];
            }
            return res;
        }
    }
}
