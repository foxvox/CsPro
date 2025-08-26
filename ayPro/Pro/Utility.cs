using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro 
{    
    public struct Vec2
    {
        public int x = 0;
        public int y = 0;

        public Vec2(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    };

    internal class Utility
    {


        private int data;

        /*
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
        */

        public void Magnitude(ref Vec2 v1, ref Vec2 v2, out float length) 
        {
            Vec2 diff = new(0, 0); 
            diff.x = v2.x - v1.x;
            diff.y = v2.y - v1.y;

            length = (float)Math.Sqrt(diff.x * diff.x + diff.y * diff.y);
        }


    }
}
