using System;

namespace Example2
{
	class Program2
	{
		static void Main()
		{
			Console.Write("Введите имя: ");
			string username = Console.ReadLine();
			Console.Write("Привет, ");
			Console.Write(username + "!");
			Console.ReadKey();
		}
	}
}
