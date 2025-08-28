using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Service
    {
        public Service() { } 
        public void Compensate(Quest quest) 
        {
            Console.WriteLine(quest.Title + "에 대한 보상이 이루어졌습니다."); 
        } 
    }
}
