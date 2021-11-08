using System;
using System.Collections.Generic;

namespace RADA
{
    class Program
    {
        static string Part1(string input)
        {
            string[] listLetRuMin = new string[31]
            {
                "щ", "е", "ё", "ж", "х", "ч", "ш", "ю", "я", "а", "б", "в", "г", "д", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф","ц","ы", "э"
            };
            string[] listLetEngMin = new string[31]
            {
                "shch","je","jo","zh", "kh", "ch","sh", "ju", "ja", "a", "b", "v", "g", "d", "z", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "c", "y", "e"
            };
            string[] listLetRuMax = new string[31]
            {
                "Щ", "Е", "Ё", "Ж", "Х", "Ч", "Ш", "Ю", "Я", "А", "Б", "В", "Г", "Д", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Ц", "Ы", "Э"
            };
            string[] listLetEngMax = new string[31]
            {
                "Shch", "Je", "Jo", "Zh", "Kh", "Ch", "Sh", "Ju", "Ja", "A", "B", "V", "G", "D", "Z", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "C", "Y", "E"
            };
            for (int i = 0; i < listLetEngMin.Length; i++)
            {

                if (input.Contains(listLetEngMin[i]))
                {
                    input = input.Replace(listLetEngMin[i], listLetRuMin[i]);
                }
                if (input.Contains(listLetEngMax[i]))
                {
                    input = input.Replace(listLetEngMax[i], listLetRuMax[i]);
                }

            }
            return input;
        }
        static string Part2(string input)
        {
            string[] listLetRuMin = new string[33]
            {
                "щ", "е", "ё", "ж", "х", "ч", "ш", "ю", "я", "а", "б", "в", "г", "д", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф","ц","ы", "э", "ь", "ъ"
            };
            string[] listLetEngMin = new string[33]
            {
                "o", "t" ,"`", ";", "[", "x", "i", ".", "z", "f", ",", "d", "u", "l", "p", "b", "q", "r", "k", "v", "y", "j", "g", "h", "c", "n", "e", "a", "w", "s", "'","m", "]"
            };
            string[] listLetRuMax = new string[33]
            {
                "Щ", "Е", "Ё", "Ж", "Х", "Ч", "Ш", "Ю", "Я", "А", "Б", "В", "Г", "Д", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Ц", "Ы", "Э", "Ь", "Ъ"
            };
            string[] listLetEngMax = new string[33]
            {
                "Щ", "Е", "~", ":", "{", "X", "I", ">", "Z", "F", "<", "D", "U", "L", "P", "B", "Q", "R", "K", "V", "Y", "J", "G", "H", "C", "N", "E", "A", "W", "S", "\"", "M", "}"
            };
            for (int i = 0; i < listLetEngMin.Length; i++)
            {

                if (input.Contains(listLetEngMin[i]))
                {
                    input = input.Replace(listLetEngMin[i], listLetRuMin[i]);
                }
                if (input.Contains(listLetEngMax[i]))
                {
                    input = input.Replace(listLetEngMax[i], listLetRuMax[i]);
                }

            }
            return input;
        }
        static void Main(string[] args)
        {
            

            string input = Console.ReadLine();


            //Console.WriteLine(Part1(input));
            Console.WriteLine(Part2(input));
        }
        
    }
}
