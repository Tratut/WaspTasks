using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B5.
    // Кол-во стингеров: ½🔷
    //
    // Написать функцию Frame(string text, char symbol), которая заключает
    // список строк text в рамку из символов char и возвращает данную строку.
    //
    // Пример:
    // frame(['Create', 'a', 'frame'], '+') ==>
    // ++++++++++
    // + Create +
    // + a      +
    // + frame  +
    // ++++++++++
    public static class TaskB5
    {
        public static string Frame(List<string> text, char symbol)
        {
            // Здесь необходимо написать код.
            int mx = 0;
            foreach (string k in text)
            {
                if (k.Length > mx) mx = k.Length;
            }
            string symBord = "";
            for (int i = 0; i < mx + 4; i++) symBord += Convert.ToString(symbol);
            text.Insert(0, symBord);
            text.Add(symBord);
            string res = "", probel;

            for (int k = 1; k < text.Count - 1; k++)
            {
                probel = "";
                for (int i = 0; i < mx - text[k].Length + 1; i++) probel += " ";
                res += Convert.ToString(symbol) + " " + text[k] + probel + Convert.ToString(symbol) + "\n";
            }
            return symBord + "\n" + res + symBord;
        }
    }
}
