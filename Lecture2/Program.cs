using System;

namespace Lecture2
{
	class Functions
	{
		static void Main()
		{
			//=======================task1==========================
			// int[] max = { 1, 2, 3, 6, 4, 5, 77, 8, 96 };
			// int Max(int arg1, int arg2, int arg3)
			// {
			// 	int result = arg1;
			// 	if (arg2 > result) result = arg2;
			// 	if (arg3 > result) result = arg3;
			// 	return result;
			// }
			// int resume = Max(Max(max[0], max[1], max[2]), Max(max[3], max[4], max[5]), Max(max[6], max[7], max[8]));
			// Console.WriteLine(resume);
			//=======================task2==========================
			// int[] arr = { 1, 2, 3, 6, 4, 5, 77, 8, 96, 77 };
			// int n = arr.Length;
			// int find = 77;
			// int index = 0;
			// while (index < n)
			// {
			// 	if (arr[index] == find) { Console.WriteLine(index); break; }
			// 	index++;
			// }
			//=======================task3==========================
			// void FillArray(int[] collection)
			// {
			// 	int length = collection.Length;
			// 	int index = 0;
			// 	while (index < length)
			// 	{
			// 		collection[index] = new Random().Next(1, 10);
			// 		index++;
			// 	}
			// }
			// void PrintArray(int[] col)
			// {
			// 	int count = col.Length;
			// 	int index = 0;
			// 	while (index < count)
			// 	{
			// 		Console.WriteLine(col[index]);
			// 		index++;
			// 	}
			// }
			// int[] array = new int[10];
			// FillArray(array);
			// PrintArray(array);

			// int IndexOf(int[] collection, int find)
			// {
			// 	int count = collection.Length;
			// 	int index = 0;
			// 	int position = -1;
			// 	while (index < count)
			// 	{
			// 		if (collection[index] == find)
			// 		{
			// 			position = index;
			// 			break;
			// 		}
			// 		index++;
			// 	}
			// 	return position;
			// }
			// Console.WriteLine();
			// int pos = IndexOf(array, 4);
			// Console.WriteLine(pos);
		}
	}
}