using System;

namespace Exapmle5
{
	class Program5
	{
		static void Main()
		{
			Console.Write("Enter Name: ");
			string username = Console.ReadLine();

			if (username.ToLower() == "Masha")
			{
				Console.WriteLine("Heeeeeeyyyy");
			}
			else
			{
				Console.WriteLine($"Hello, {username}");
			}
			Console.Write("Write a float number, use coma for separate: ");
			float user_name = float.Parse(Console.ReadLine());
			float result = user_name + 10f;
			System.Console.WriteLine($"Your number + 10 = {result}");
		}
	}

}
