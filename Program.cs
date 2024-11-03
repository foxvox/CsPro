namespace CsPro
{
	class Test
	{
		int[] array = [10, 20, 30, 40, 50];
		int index;
 
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

		public int Array
		{
			get
			{
				return array[index];
			}
			set
			{
				array[index] = value;
			}
		}
		
		public int ArrayLength
		{
			get
			{
				return array.Length;
			}
		}

		public int Index
		{
			set
			{
				index = value; 
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Test test = new Test(); 
			test[2] = 700; 
			for (int i = 0; i < test.ArrayLength; i++)
			{
				Console.WriteLine($"{test[i]}"); 
			}

			test.Index = 2; 
			Console.WriteLine(test.Array); 
		}
	}
}
