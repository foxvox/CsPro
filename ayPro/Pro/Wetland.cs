using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Wetland : Terrain, IMutable 
    {
        public Wetland() 
        {
            width = 30; height = 30; 
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }

        public override void Describe() 
        {
            Console.WriteLine("Wetlnad 입니다.");
            Console.WriteLine("width: " + width + " , " + "height: " + height); 
        }

        void IMutable.Mutable() 
        {
            throw new NotImplementedException();
        }
    }
}
