
using System.IO; 

namespace CsPro 
{
	class Program
	{
		static void Main(string[] args)
		{
			FileInfo fi = new FileInfo(@"C:/csharpex/test.txt");
			DirectoryInfo di = new DirectoryInfo(@"c:/csharpex"); 

			if (fi.Exists)
			{
				Console.WriteLine("파일이 존재합니다.");
			}
			else
			{
				Console.WriteLine("파일이 존재하지 않습니다.");
			}

			if (di.Exists)
			{
				Console.WriteLine("디렉토리가 존재합니다.");
				Console.WriteLine(di.Attributes);
				Console.WriteLine(di.CreationTime); 
				Console.WriteLine(di.Exists);
				Console.WriteLine(di.FullName);
				Console.WriteLine(di.LastAccessTime);
				Console.WriteLine(di.Name);
				Console.WriteLine(di.Parent);
				Console.WriteLine(di.Root);
			}
			else
			{
				Console.WriteLine("디렉토리가 존재하지 않습니다."); 
			}
		}
	}
}
