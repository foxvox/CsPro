using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Item
    { 
        public string Name { get; set; }  
        public int Strength {  get; set; } = 0;
        public int Agility { get; set; } = 0; 
        public int Intelligence { get; set; } = 0; 

        public Item(string name, int strength, int agility, int intelligence)  
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
        } 
    }
}
