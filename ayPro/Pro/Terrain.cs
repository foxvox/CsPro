using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal abstract class Terrain 
    {
        protected int width = 0; 
        protected int height = 0; 

        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Height 
        {
            // => expression bodied operator 
            get => height; 
            set => height = value;  
        } 
        public abstract void Describe();
        public abstract void Activate(); 
    }
}
