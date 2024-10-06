namespace CsPro
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = new { Name = "박상현", Age = 123 }; 
			Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");

			var b = new { Subject = "수학", Score = new int[] { 90, 80, 70, 60 } };

			Console.Write($"Subject: {b.Subject}, Score: ");
			foreach (var score in b.Score) 
			{ 
				Console.Write($"{score} ");				
			}

			Console.WriteLine();
		}
	}
}
