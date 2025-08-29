using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Princess : IMovable 
    {
        public Princess() { }

        public void Move() 
        {
            Console.WriteLine("Princess Move"); 
        }
    }
}
