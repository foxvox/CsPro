using Pro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

class Program
{
    static void Main() 
    {
        Terrain terrain = new Forrest(); 
        terrain.Describe();
        terrain = new Grassland(); 
        terrain.Describe(); 
        terrain = new Wetland(); 
        terrain.Width = 50; 
        terrain.Describe(); 
    }
}
