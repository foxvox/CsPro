using System;
using System.Security.Permissions; 
using System.Threading;

namespace CsPro
{
	class Counter 
	{
		const int LOOP_COUNT = 100;
		readonly object thisLock;

		private int count; 
		public int Count
		{
			get { return count; } 
		}

		public Counter()
		{
			thisLock = new object();
			count = 0;	
		}

		public void Increase()
		{
			int loopCount = LOOP_COUNT;

			while (loopCount-- > 0)
			{
				Monitor.Enter(thisLock);
				try
				{
					count++;
				}
				finally
				{
					Monitor.Exit(thisLock);
				}
				Thread.Sleep(1);
			}
		}

		public void Decrease()
		{
			int loopCount = LOOP_COUNT;
			while (loopCount-- > 0)
			{
				Monitor.Enter(thisLock);
				try
				{
					count--;
				}
				finally
				{
					Monitor.Exit(thisLock);
				}
				Thread.Sleep(1);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Counter counter = new Counter();

			Thread incThread = new (counter.Increase); 
			Thread decThread = new (() => counter.Decrease()); 

			incThread.Start();	
			decThread.Start();

			incThread.Join();
			decThread.Join();

			Console.WriteLine(counter.Count);
		}
	}
}
