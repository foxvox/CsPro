namespace Pro
{
    internal class Program
    {


        static void Main(string[] args)
        {
            /*
            #region 박싱
            // 값형식의 데이터를 참조형식으로 변환하는 과정입니다. 
            int value = 100; 
            object obj1 = value;             

            Console.WriteLine("value: " + value);
            Console.WriteLine("obj: " + obj1);

            #endregion

            #region 언박싱 
            // 참조형식의 데이터를 값형식으로 변환하는 과정입니다. 
            int box = (int)obj1;

            Console.WriteLine("\nbox: " + box);

            #endregion 
            */

            Utility util = new(); 

            int a = 100; 
            int b = 200;
            int minus = -400; 

            Console.WriteLine("Swap 전 => a: " + a + "  " + "b: " + b); 
            Utility.Swap(ref a, ref b); 
            Console.WriteLine("Swap 후 => a: " + a + "  " + "b: " + b);

            int abs = Utility.Absolute(in minus);  
            Console.WriteLine("abs: " + abs); 
        }
    }
}
