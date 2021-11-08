using System;

namespace RADA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine((n % 100 - n % 10) / 10);
        }
    }
}
