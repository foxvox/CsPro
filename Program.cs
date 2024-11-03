
namespace CsPro 
{
	delegate void MyDelegate(); 

	class Test
	{
		public static void Hello()
		{
			Console.WriteLine("Test 클래스의 static Hello()"); 
		}

		public static MyDelegate MyHello
		{
			get
			{
				return Hello; 
			}
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			MyDelegate hello = Test.MyHello; 
			hello(); 
		}
	}
}
