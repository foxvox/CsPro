using Pro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Pro
{
    class Program
    {
        static void Main(string[] args) 
        {
            #region 단일책임원칙 
            //List<Quest> qList = new List<Quest>();

            //qList.Add(new Quest("스킬 배우기", "팜팻 3마리 처치", new Reward(100, 20)));
            //qList.Add(new Quest("전직", "스켈레톤 100마리 처치", new Reward(200, 40)));
            //qList.Add(new Quest("무기 강화석 획득", "오크 20마리 처치", new Reward(300, 80)));

            //foreach (Quest q in qList)
            //{
            //    q.Describe();
            //}

            //Service service = new Service();

            //service.Compensate(qList[1]);
            #endregion

            #region 개방폐쇄원칙  

            Enchant enchant = new Enchant();

            enchant.Boost(new Item("Sword", 10, 5, 0));
            enchant.Boost(new Item("Necklace", 1, 1, 10));
            enchant.Boost(new Item("Shoes", 0, 20, 0)); 

            #endregion
        }
    }
}


