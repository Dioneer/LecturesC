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
				Console.Write("Hello, ");
				Console.WriteLine(username);
			}

			float user_name = float.Parse(Console.ReadLine());
			float result = user_name + 10f;
			Console.WriteLine(result);
			System.Console.WriteLine("easy cw");
		}
	}

}
