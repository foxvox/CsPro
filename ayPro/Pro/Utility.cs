using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Utility
    {
        private int data;

        public void Pause()
        {
            Console.WriteLine("Pause...");
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static int Absolute(in int value) 
        {
            int temp = value;

            if (value < 0)
                temp = -value;
            
            return temp; 
            
        }
    }
}
