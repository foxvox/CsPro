using System;
using System.IO;
using System.Collections.Generic; 
using System.Threading;
using System.Threading.Tasks;

namespace CsPro
{
	class Program
	{
		async static private void MyMethodAsync(int count)
		{
			Console.WriteLine("C");
			Console.WriteLine("D");

			await Task.Run(async () =>
			{
				for (int i = 1; i <= count; i++)
				{
					Console.WriteLine($"{i} / {count} ...");
					await Task.Delay(1000);
				}
			});

			Console.WriteLine("G");
			Console.WriteLine("H"); 
		}

		static void Caller()
		{
			Console.WriteLine("A"); 
			Console.WriteLine("B");

			MyMethodAsync(3); 

			Console.WriteLine("E");
			Console.WriteLine("F");
		}

		static void Main(string[] args)
		{
			Caller();

			Console.ReadLine(); 

		}
	}
}
