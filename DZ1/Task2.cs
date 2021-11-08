using System;


namespace std
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            if (x == x2 || y == y2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");


        }
    }
}
