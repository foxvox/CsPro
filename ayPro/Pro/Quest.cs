using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class Quest
    {
        private Reward reward; 

        public string Title { get; set; }
        public string Description { get; set; } 

        private bool Completed { get; set; } = false;  
        public Quest(string title, string content, Reward _reward)
        {
            reward = new Reward(_reward.Coin, _reward.Exp); 

            Title = title;
            Description = content; 
        } 

        public void Describe()
        {
            Console.WriteLine("Title: " + Title); 
            Console.WriteLine("Description: " + Description); 
            reward.Describe(); 
        }
    }
}
