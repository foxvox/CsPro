using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Enchant 
    {
        public Enchant() { }
        public void Boost(Item item) 
        {
            if (item.Name == "Sword")
            {
                item.Strength = 5; 
            }
            else if (item.Name == "Necklace") 
            {
                item.Intelligence = 10; 
            }
            else if (item.Name == "Shoes")
            {
                item.Agility = 10; 
            }
        }

    }
}
