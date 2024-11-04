
namespace CsPro 
{
	class Program
	{
		static void Main(string[] args)
		{
			FileInfo f = new FileInfo(@"c:/csharpex/test.txt");
			if (f.Exists)
			{
				f.CopyTo(@"c:/csharpex/test2.txt");
				Console.WriteLine("파일이 정상적으로 복사되었습니다.");
			}
			else
			{
				Console.WriteLine("파일이 존재하지 않습니다."); 
			}
		}
	}
}
