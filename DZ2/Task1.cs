using System;

namespace RADA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine((k - k % n) / n);
        }
    }
}
