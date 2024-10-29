using System.Threading; 

namespace CsPro
{
	class Program
	{
		static void DoSomething()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"DoSomething: {i}");
				Thread.Sleep(10); 
			}
		}

		static void Main(string[] args)
		{
			Thread t1 = new Thread(DoSomething);

			Console.WriteLine("Starting thread..."); 
			t1.Start();

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"Main: {i}");
				Thread.Sleep(10);
			}

			Console.WriteLine("Waiting until thread stops...");
			t1.Join();

			Console.WriteLine("Finished"); 	
		}
	}
}
