using System;
using System.Collections.Generic;

namespace Aga_Da
{
    class Program
    {
        static int[] ConvToInt(string[] x)
        {
            int[] masRes = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                masRes[i] = Convert.ToInt32(x[i]);
                
            }
            return masRes;

        }

        static void Task5()
        {
            int[] mas1 = ConvToInt(Console.ReadLine().Split());
            int[] mas2 = ConvToInt(Console.ReadLine().Split());
            int[] masRes = new int[mas1.Length];
            for (int i = 0; i < mas1.Length; i++)
            {
                masRes[i] = mas1[i] + mas2[i];
                Console.Write(masRes[i] + " ");
            }
        }
        static void Task7()
        {
            int[] mas1 = ConvToInt(Console.ReadLine().Split());
            int[] mas2 = ConvToInt(Console.ReadLine().Split());
            double sum = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                sum += mas1[i];
            }
            for (int i = 0; i < mas2.Length; i++)
            {
                sum += mas2[i];
            }
            Console.WriteLine(sum / (mas1.Length + mas2.Length));
        }
        static void Task6()
        {
            int[] mas1 = ConvToInt(Console.ReadLine().Split());
            int[] mas2 = ConvToInt(Console.ReadLine().Split());
            double kol = 0;

            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] == mas2[i])
                {
                    kol++;
                }
            }

            Console.WriteLine(kol / mas1.Length);
        }
        static void Task4(int[] x, int[,] y) // Не работает
        {
            List<int> uniq = new List<int>();
            foreach (int i in y) // достаю уникальные значения из 2х мерного массива
            {
                if (uniq.Contains(i) == false)
                {
                    uniq.Add(i);
                }
            }
            for (int i=0; i < y.GetLength(0); i++)
            {
                for (int j=0; j < y.GetLength(1); j++)
                {
                    if (uniq.Contains(y[i,j]) == false)
                    {
                        uniq.Remove(i);
                    }
                }
            }
            foreach(int i in x)
            {
                if (uniq.Contains(i)) Console.Write(i + " ");
            }

        }
        static dynamic Task3(dynamic x, dynamic y) // массивы кладутся в функцию и возращаются(это же аналогично "добавить"?) в программу
        {
            return (x, y);
        }
        static void Task2(dynamic mas)
        {
            int max = 0, kol = 0;

            foreach (int m in mas)
            {
                if (m > max)
                {
                    max = m;
                }
            }
            foreach (int m in mas)
            {
                if (m == max)
                {
                    kol++;
                }
            }
            Console.WriteLine("MAx = " + max + "  Kol = " + kol);
        }
        static void Task1()
        {
            Console.WriteLine("1-одномерный 2-двумерный");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Ввод(через пробел):");
                int[] mas = ConvToInt(Console.ReadLine().Split());
                Console.WriteLine("Вывод:");
                foreach(int i in mas)
                {
                    Console.Write(i + " ");
                }
            }
            else if (x == 2)
            {
                Console.WriteLine("Количество подмассивов");
                int kolPod = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Количество элементов в подмассиве");
                int koleEl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввод(через enter):");
                int[,] mas = new int[kolPod, koleEl];
                for(int i = 0; i < kolPod; i++)
                {
                    for (int j = 0; j < kolPod; j++)
                    {
                        mas[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Вывод:");
                for (int i = 0; i < kolPod; i++)
                {
                    for (int j = 0; j < kolPod; j++)
                    {
                        Console.Write(mas[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            //Task5();
            //Task7();
            //Task6();
            //////////////////////////////////////////
            int[] mas1 = new int[5] { 1,2,3,4,5};
            int[,] mas2 = new int[2, 3] { { 1, 2, 6 }, { 1, 3, 6 } };
            //Task4(mas1, mas2);
            //////////////////////////////////////////
            //Console.WriteLine(Task3(mas1, mas2));
            //Task2(mas2);
            Task1();
        }
    }
}
