using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Mercenary : IMovable, IAttackable
    {
        public Mercenary() { }

        public void Move()
        {
            Console.WriteLine("Mercenary Move"); 
        }

        public void TakeDamage()
        {
            Console.WriteLine("Mercenary is Damaged"); 
        }
    }
}
