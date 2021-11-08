using System;

namespace RADA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int box;
            int res = 0;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                box = n % 10;
                n = (n - box) / 10;
                res = res * 10 + box;
            }
            Console.WriteLine(res);
        }
    }
}
