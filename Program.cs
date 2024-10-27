
namespace CsPro
{
	// 대리자 => 함수 참조 클래스  
	delegate void Notify(string _message); 
	
	class Notifier
	{
		public Notify EventOccured; 
	}

	class EventListener
	{
		private string name; 
		public EventListener(string _name)
		{
			name = _name; 
		}

		public void SomethingHappened(string _message)
		{
			Console.WriteLine($"{name}.SomethingHappened: {_message}"); 
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Notifier notifier = new Notifier();
			EventListener listener1 = new EventListener("Listener1");
			EventListener listener2 = new EventListener("Listener2");
			EventListener listener3 = new EventListener("Listener3");

			notifier.EventOccured += listener1.SomethingHappened;
			notifier.EventOccured += listener2.SomethingHappened;
			notifier.EventOccured += listener3.SomethingHappened;
			notifier.EventOccured("You've go mail.");

			Console.WriteLine();

			notifier.EventOccured -= listener2.SomethingHappened;
			notifier.EventOccured("Download complete."); 

			Console.WriteLine();

			notifier.EventOccured = new Notify(listener1.SomethingHappened) 
									+ new Notify(listener3.SomethingHappened);
			notifier.EventOccured("Nuclear launch detected."); 

			Console.WriteLine();

			Notify notify1 = new Notify(listener1.SomethingHappened); 
			Notify notify2 = new Notify(listener2.SomethingHappened);

			notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
			notifier.EventOccured("Fire"); 

			Console.WriteLine();

			notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
			notifier.EventOccured("RPG!"); 
		}
	}
}
