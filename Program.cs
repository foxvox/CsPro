using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CsPro
{
	class Program
	{
		private static Thread workerThread;
		private static bool isRunning = true;

		static void Main(string[] args)
		{
			// 스레드 생성 및 시작
			workerThread = new Thread(DoWork);
			workerThread.Start();

			Console.WriteLine("Press Enter to stop the worker thread...");
			Console.ReadLine();

			// 스레드 중단
			isRunning = false;

			// 스레드가 종료될 때까지 대기
			workerThread.Join();
			Console.WriteLine("Worker thread has stopped.");
		}

		private static void DoWork()
		{
			while (isRunning)
			{
				Console.WriteLine("Working...");
				Thread.Sleep(1000); // 1초 대기
			}
		}
	}
}
