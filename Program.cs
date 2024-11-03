
namespace CsPro
{
	class TestClass
	{
		int[] array = [10, 20, 30, 40, 50];

		//인덱서 시작 
		public int this[int index]
		{
			get
			{
				if (index >= 0 && index < array.Length)
				{
					return array[index];
				}
				else
				{
					return -1;
				}
			}
			set
			{
				if (index >= 0 && index < array.Length)
				{
					array[index] = value;
				}
				else
				{
					Console.WriteLine("array 범위를 벗어났습니다.");
				}
			}
		}

		//ArrayLength 속성 
		public int ArrayLength
		{
			get
			{
				return array.Length;
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			TestClass test = new TestClass(); 
			test[2] = 600; 
			for (int i = 0; i < test.ArrayLength; i++)
			{
				Console.WriteLine($"{test[i]}"); 
			}
		}
	}
}
