
namespace CsPro 
{
	delegate void MyTextChangedEventHandler(object send, EventArgs e);

	class MyForm 
	{
		private MyTextBox? myTextBox1; 

		static void Main(string[] args)
		{
			MyForm myForm1 = new MyForm();
			myForm1.Run(); 
		}

		public void Run()
		{
			myTextBox1 = new("C++");

			//TextChanged 대리자에 의해 실행될 함수를 미리 할당해 둔다. 
			myTextBox1.TextChanged += new(MyTextBox1_TextChanged1); 
			myTextBox1.TextChanged += new(MyTextBox1_TextChanged2);

			//C++ 출력 
			myTextBox1.Paint();

			//myTextBox1의 Text속성이 set되면서 OnTextChanged 함수 호출
			//OnTextChanged 함수 안에서 TextChanged 함수가 호출된다. 	
			myTextBox1.Text = "C#";

			//C# 출력 
			myTextBox1.Paint(); 
		}

		public void MyTextBox1_TextChanged1(object send, EventArgs e)
		{
			Console.WriteLine("택스트가 변경되었습니다."); 
		}

		public void MyTextBox1_TextChanged2(object send, EventArgs e)
		{
			Console.WriteLine("변경된 텍스트는 {0}입니다.\n", myTextBox1.Text); 
		}
	}

	class MyTextBox
	{
		private string text;

		public event MyTextChangedEventHandler TextChanged;

		public MyTextBox(string str)			
		{
			text = str; 
		}

		public string Text
		{
			get { return text; }

			set
			{
				text = value;
				OnTextChanged(EventArgs.Empty);
			}
		}

		public void Paint()
		{
			Console.WriteLine("----------");
			Console.WriteLine("| {0}", text); 
			Console.WriteLine("----------");
		}

		protected void OnTextChanged(EventArgs e)
		{
			//MyForm의 Run 함수가 실행되면서 TextChanged 대리자에 MyTextBox1_TextChanged1 
			//MyTextBox1_TextChanged2가 차례로 호출되게끔 미리 할당되어 있음 
			if (TextChanged != null)
			{
				//여기에서 MyForm에 구현되어 있는 MyTextBox1_TextChanged1 
				//그리고 MyTextBox1_TextChanged2가 차례로 호출된다. 
				TextChanged(this, e);
			}
		}
	}
}
