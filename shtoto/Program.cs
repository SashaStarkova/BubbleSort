using System;

namespace shtoto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число");
			try
			{
				int a = int.Parse(Console.ReadLine());
				int[] arr = new int[10];
				Random R = new Random();
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = R.Next(0, a + 1);
					Console.Write(arr[i] + "   ");
				}
				for (int i = 0; i < arr.Length; i++)
					for (int j = 1; j < arr.Length - i; j++)
					{
						if (arr[j] < arr[j - 1])
						{
							int s = arr[j];
							arr[j] = arr[j - 1];
							arr[j - 1] = s;
						}
					}
				Console.WriteLine();
				for (int i = 0; i < arr.Length; i++)
				{
					Console.Write(arr[i] + "   ");
				}
				Console.WriteLine();
				Console.WriteLine("Введите число, которое нужно найти в массиве");
				int CH = int.Parse(Console.ReadLine());
				for (int i = 0; i < arr.Length; i++)
					if (CH == arr[i])
						Console.WriteLine(i+1);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Console.ReadKey();
		}
	}
}
