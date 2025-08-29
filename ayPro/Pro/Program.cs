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

            //List<IEnchantable> enchantables = new List<IEnchantable>();
            //enchantables.Add(new Sword("Sword", 10, 10, 10));  
            //enchantables.Add(new Necklace("Necklace", 20, 20, 20));
            //enchantables.Add(new Shoes("Shoes", 30, 30, 30));

            //Enchant enchant = new Enchant();  

            //foreach (var e in enchantables)
            //{
            //    enchant.Upgrade(e); 
            //} 

            #endregion

            #region 인터페이스분리원칙 

            #endregion 
        }
    }
}


