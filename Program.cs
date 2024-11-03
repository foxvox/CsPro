
namespace CsPro 
{
	delegate void MyEventHandler();

	class MyButton
	{
		public event MyEventHandler Event;
		public void OnClick()
		{
			Event();
		}
	}

	class Program
	{
		void BtnClick()
		{
			Console.WriteLine("버튼에서 이벤트 발생!"); 
		}

		public Program()
		{
			//MyButton 객체 생성 
			MyButton btn = new ();

			//버튼에서 이벤트가 발생하면 BtnClick함수가 호출되게끔 미리 할당해 둔다.   
			btn.Event += BtnClick;

			//버튼이 클릭되면 이벤트 전용 delegate Event가 호출된다. 위에서 미리 할당해 둔 BtnClick()함수가 호출된다.  
			btn.OnClick(); 

		}

		//expression bodied for Main Method: 메인 메서드에 대한 식본문 정의 
		static void Main(string[] args) => new Program();
	}	
}
