using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Sword : Item, IEnchantable 
    {
        public Sword(string _name, int _strength, int _agility, int _intelligence) : base(_name, _strength, _agility, _intelligence) 
        {} 

        public void Upgrade() 
        {
            Console.WriteLine("Sword가 업그레이드 되었습니다."); 
        }
    }
}
