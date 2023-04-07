using System;

namespace Example7
{
	class Program6
	{
		static void Main()
		{
			int a = 1;
			int b = 2;
			int c = 6;
			int e = 8;

			int max = a;

			if (b > max) max = b;
			if (c > max) max = c;
			if (e > max) max = e;

			Console.Write($"max ={max}");
		}
	}
}
