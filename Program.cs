
namespace CsPro
{
	class Program
	{
		static void Main(string[] args)
		{
			Action act1 = () => Console.WriteLine("act1()");
			act1();

			int result = 0;
			Action<int> act2 = (x) => result = x * x;
			act2(3);
			Console.WriteLine($"act2(3): result: {result}");

			Action<double, double> act3 = (x, y) =>
			{
				double pi = x / y;
				Console.WriteLine($"act3<double, double>({x}, {y}): {pi}"); 
			};
			act3(22.0, 7.0); 		
		}
	}
}
