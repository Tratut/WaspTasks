using System;


namespace For_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            if ((Math.Abs(x1 - x2) <= 1) && (Math.Abs(y1 - y2) <= 1))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
