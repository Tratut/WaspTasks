using System;


namespace For_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x >= m / 2)
                x = m - x;
            if (y >= n / 2)
                y = n - y;
            if (x > y)
                Console.WriteLine(y);
            else
                Console.WriteLine(x);

        }
    }
}
