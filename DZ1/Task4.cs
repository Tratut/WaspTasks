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

            if ((x - n == -1 || x - n == 1) && (y - m == -1 || y - m == 1))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
