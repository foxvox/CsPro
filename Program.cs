using System;
using System.Collections;
using System.Collections.Generic; 

namespace CsPro
{
	class MyList<T> : IEnumerable<T>, IEnumerator<T>
	{
		private T[] array;
		int position = -1;

		public MyList()
		{
			array = new T[3];
		}

		public T this[int index]
		{
			get
			{
				return array[index];
			}

			set
			{
				if (index >= array.Length)
				{
					Array.Resize(ref array, index + 1);
					Console.WriteLine($"Array Resized: {array.Length}");
				}

				array[index] = value; 
			}
		}

		public int Length 
		{ 
			get { return array.Length; } 
		}

		public IEnumerator<T> GetEnumerator()
		{
			return this; 
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}

		public T Current
		{
			get { return array[position]; } 
		} 

		object IEnumerator.Current
		{
			get { return array[position]; }
		}

		public void Reset()
		{
			position = -1; 
		}

		public void Dispose()
		{} 

		public bool MoveNext()
		{
			if (position == array.Length - 1)
			{
				Reset(); 
				return false; 
			}

			position++;
			return (position < array.Length); 
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> strList = new MyList<string>(); 
			strList[0] = "abc"; strList[1] = "def"; strList[2] = "ghi"; strList[3] = "jkl"; strList[4] = "mno";

			foreach (string str in strList)			
				Console.WriteLine(str);			
			Console.WriteLine(); 

			MyList<int> intList = new MyList<int>(); 
			intList[0] = 0; intList[1] = 1; intList[2] = 2; intList[3] = 3; intList[4] = 4; 

			foreach (int i in intList) 
				Console.WriteLine(i); 
			Console.WriteLine(); 		
		}
	}
}
