using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Forrest : Terrain, IMutable
    {
        public Forrest() 
        {
            width = 10; height = 10;
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }

        public override void Describe() 
        {
            Console.WriteLine("Forrest 입니다."); 
            Console.WriteLine("width: " + width + " , " + "height: " + height); 
        }

        public void Mutable()
        {
            throw new NotImplementedException();
        }
    }
}
