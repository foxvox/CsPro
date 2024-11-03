
namespace CsPro 
{
	delegate void MyDelegate(); 

	class Test
	{
		public void Hello()
		{
			Console.WriteLine("Hello World!"); 
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Test t = new();
			t.Hello(); 

			//메서드의 참조가 들어감 
			MyDelegate hello = t.Hello;
			hello(); 
		}
	}
}
