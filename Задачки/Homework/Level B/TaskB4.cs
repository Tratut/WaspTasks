using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B4.
    // Кол-во стингеров: 🔷
    //
    // Написать функцию CheckBrackets(string s), которая определяет,
    // правильно ли расставлены скобки () {} [] <> в предложении.
    //
    // Примеры:
    // CheckBrackets("(abc)[]{0:1}") ==> true;
    // CheckBrackets("(abc)]{0:1}[") ==> false.
    public static class TaskB4
    {
        public static bool CheckBrackets(string s)
        {
            // Здесь необходимо написать код.
            char[] mas, chek = { '(', ')', '{', '}', '[', ']', '<', '>' };
            mas = s.ToCharArray();
            bool flag = false;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == '(' || mas[i] == '{' || mas[i] == '[' || mas[i] == '<')
                    if (mas[i] == '(')
                    {
                        for (int j = i; j < mas.Length; j++)
                        {
                            if (mas[j] == mas[i] + 1)
                            {
                                mas[i] = '0';
                                mas[j] = '0';
                            }
                            else if (chek.Contains(mas[j]) && mas[j] != ')') return false;
                        }
                    }
                    if (mas[i] == '{')
                    {
                        for (int j = i; j < mas.Length; j++)
                        {
                            if (mas[j] == mas[i] + 2)
                            {
                                mas[i] = '0';
                                mas[j] = '0';
                            }
                            else if (chek.Contains(mas[j]) && mas[j] != '}') return false;
                        }
                    }
                    if (mas[i] == '[')
                    {
                        for (int j = i; j < mas.Length; j++)
                        {
                            if (mas[j] == mas[i] + 2)
                            {
                                mas[i] = '0';
                                mas[j] = '0';
                            }
                            else if (chek.Contains(mas[j]) && mas[j] != ']') return false;
                        }
                    }
                    if (mas[i] == '<')
                    {
                        for (int j = i; j < mas.Length; j++)
                        {
                            if (mas[j] == mas[i] + 2)
                            {
                                mas[i] = '0';
                                mas[j] = '0';
                            }
                            else if (chek.Contains(mas[j]) && mas[j] != '>') return false;
                        }
                    }

            }
            foreach (char k in mas)
            {
                if (chek.Contains(k)) flag = true;
            }
            if (flag) return false;
            return true;
        }
    }
}
