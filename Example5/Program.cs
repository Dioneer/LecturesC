// See https://aka.ms/new-console-template for more information
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
