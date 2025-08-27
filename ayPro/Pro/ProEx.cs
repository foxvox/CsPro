using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class ProEx
    {
        static void Main()
        {
            // Stack 생성
            Stack<string> stack = new Stack<string>();

            // 요소 추가 (Push)
            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Cherry");

            Console.WriteLine("현재 스택 상태:");
            foreach (var item in stack)
                Console.WriteLine(item);

            // 요소 제거 (Pop)
            string popped = stack.Pop();
            Console.WriteLine($"\nPop된 요소: {popped}");

            // 최상단 요소 확인 (Peek)
            string top = stack.Peek();
            Console.WriteLine($"현재 최상단 요소: {top}");

            // 요소 개수 확인
            Console.WriteLine($"스택에 남은 요소 수: {stack.Count}\n");


            Queue<int> q = new Queue<int>();

            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
