using System;

namespace Example3
{
	class Program3
	{
		static void Main()
		{
			int numberA = new Random().Next(1, 10);
			int nubmerB = new Random().Next(1, 10);
			byte numberC = 12;
			float numberD = 1.236545f;
			numberC += 4;
			int result = numberA + nubmerB;
			Console.WriteLine("result: " + result);
			Console.WriteLine("numberC: " + numberC);
			Console.WriteLine("float: " + numberD);
		}
	}
}
