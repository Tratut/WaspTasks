using System;

namespace RADA
{
    class Program
    {
        static void Main(string[] args)
        {
            float h = int.Parse(Console.ReadLine());
            float a = int.Parse(Console.ReadLine());
            float b = int.Parse(Console.ReadLine());
            Console.WriteLine(1 + (h - b - 1) / (a - b));
        }
    }
}
