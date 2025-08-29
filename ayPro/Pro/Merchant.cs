using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Merchant : ITradable
    {
        public Merchant() { }

        public void Trade()
        {
            Console.WriteLine("Shop Open"); 
        }
    }
}
