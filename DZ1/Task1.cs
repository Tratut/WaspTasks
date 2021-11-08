using System;
namespace std;
{
	public class Class1
	{
		public Class1()
		{
			static void Main(string[] args)
			{
				int x = Console.ReadLine();
				int y = Console.ReadLine();
				int z = Console.ReadLine();
				if (x == y && y == z)
					Console.WriteLine(3);
				else if (x == y || x == || z || y == z)
					Console.WriteLine(2);
				else
					Console.WriteLine(0);
			}

		}
	}
}
