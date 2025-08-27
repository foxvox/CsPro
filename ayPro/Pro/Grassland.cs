using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Grassland : Terrain, ICoverable, IMutable
    {
        public Grassland() 
        {
            width = 20; height = 20;
        }

        public override void Describe() 
        {
            Console.WriteLine("Grassland 입니다.");
            Console.WriteLine("width: " + width + " , " + "height: " + height); 
        }

        public void Coverable()
        {
            throw new NotImplementedException(); 
        }

        public void Mutable()
        {
            throw new NotImplementedException();
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }
    }
}
