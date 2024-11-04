
using System.IO; 

namespace CsPro 
{
	class Program
	{
		static void Main(string[] args)
		{
			FileInfo fi = new FileInfo(@"C:/csharpex/test.txt");

			if (fi.Exists)
			{
				Console.WriteLine("파일이 존재합니다.");
			}
            else
            {
				Console.WriteLine("파일이 존재하지 않습니다."); 
            }
        }
	}	
}
