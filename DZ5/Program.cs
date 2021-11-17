using System;
using System.Collections.Generic;
using System.Linq;

namespace Aga_Da
{
    class Program
    {
        static void SingleElement()
        {
            int useless_num = int.Parse(Console.ReadLine());
            string x = Console.ReadLine();
            List<string> uniq = new List<string>();
            string[] all = x.Split();
            foreach (string i in all)
            {
                if (uniq.Contains(i)) continue;
                else uniq.Add(i);
            }
            int kol = 0;
            foreach(string i in uniq)
            {
                kol = 0;
                for (int k=0; k < all.Length; k++)
                {
                    if (all[k] == i)
                    {
                        kol++;
                    }
                }
                if (kol == 1) Console.Write(i + " ");
            }

        }
        static void Sort()
        {
            int useless_num = int.Parse(Console.ReadLine());
            string[] masString = Console.ReadLine().Split();
            int[] masInt = new int[useless_num];
            for (int k = 0; k < useless_num; k++)
            {
                masInt[k] = int.Parse(masString[k]);
            }
            bool flag = false;
            int swap;
            do // buble sort
            {
                flag = false;
                for (int i = 1; i < useless_num; i++)
                {
                    if (masInt[i - 1] < masInt[i])
                    {
                        swap = masInt[i - 1];
                        masInt[i - 1] = masInt[i];
                        masInt[i] = swap;
                        flag = true;
                    }
                }
            } while (flag);
            foreach(int k in masInt)
            {
                Console.Write(k + " ");
            }
        }
        static void StepenOfNumber()
        {
            int m = int.Parse(Console.ReadLine()), x = int.Parse(Console.ReadLine());
            double res = Math.Log(x, m);
            if (res == Convert.ToInt32(res)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
        static void AverageDeviation()
        {
            List<int> ls = new List<int>();
            int input = Convert.ToInt32(Console.ReadLine());
            while (input != 0)
            {
                ls.Add(input);
                input = Convert.ToInt32(Console.ReadLine());
            }


            double sum = 0;
            foreach(int i in ls)
            {
                sum += i;
            }
            sum /= ls.Count();
            double res = 0;
            for (int i = 0; i < ls.Count(); i++)
            {
                res += Math.Pow(ls[i] - sum, 2);
            }
            Console.WriteLine(Math.Sqrt(res / (ls.Count() - 1)));
        }
        static void Kegli()
        {
            string[] usl = Console.ReadLine().Split();
            int n = Convert.ToInt32(usl[0]), k = Convert.ToInt32(usl[1]);
            string[] masChange = new string[n];
            for (int i = 0; i < n; i++) masChange[i] = "I";
            for (int i = 0; i < k; i++)
            {
                string[] ni = Console.ReadLine().Split();
                int g = Convert.ToInt32(ni[0]), ers = Convert.ToInt32(ni[1]);
                for (int j = g - 1; j < ers; j++) masChange[j] = ".";
            }
            foreach (string i in masChange) Console.Write(i);
        }
        static void Main(string[] args)
        {
            //SingleElement();
            //Sort();
            //StepenOfNumber();
            //AverageDeviation();
            //Kegli();
        }
    }
}
