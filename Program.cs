
namespace CsPro 
{
	class Program
	{
		static void Main(string[] args)
		{
			FileInfo f = new FileInfo(@"c:/csharpex/test.txt");
			if (f.Exists)
			{
				f.Delete();
				Console.WriteLine("파일이 삭제되었습니다."); 
			}
			else
			{
				Console.WriteLine("파일이 존재하지 않습니다."); 
			}
		}
	}
}
