using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Reward
    {
        public int Coin { get; set; } = 0; 
        public int Exp { get; set; } = 0;
        public Reward(int coin, int exp) 
        {
            Coin = coin;
            Exp = exp;
        } 

        public void Describe()
        {
            Console.WriteLine(Coin + " 골드 획득했습니다." + " , " + Exp + " 경험치 획득했습니다."); 
            Console.WriteLine();
        }
    }
}
