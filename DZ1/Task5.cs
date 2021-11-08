using System;


namespace For_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            if (v * t == 0)
                Console.WriteLine(0);
            else if (v * t < 109)
                Console.WriteLine(109 - v * t);
            else
                Console.WriteLine(v * t / 109 + v * t % 109 - 1);
        }
    }
}
