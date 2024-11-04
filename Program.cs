
namespace CsPro 
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamWriter sw = new StreamWriter(new FileStream(@"c:/csharpex/write.txt", FileMode.Create));
			sw.WriteLine("Hello World!");
			sw.Close();
			Console.WriteLine("파일에 정상적으로 문자열을 추가하였습니다."); 
		}
	}
}
