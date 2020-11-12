using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_9
{
    internal class Human
    {
        private string name;
        private byte skillLevel;

        public string GetName
        {
            get
            {
                return this.name;
            }
        }

        public byte GetSkillLevel
        {
            get
            {
                return this.skillLevel;
            }
        }

        public Human(string name, byte skillLevel)
        {
            this.name = name;
            this.skillLevel = skillLevel;
        }

        public event WorkHandler OnWork;
        public event UpgradeHandler OnUpgrade;

        public void StartWork(int duration)
        {
            Console.WriteLine($"User {this.name} with skill-level {this.skillLevel} started to work  ");
            OnWork?.Invoke(duration);
            if (duration > 5000)
            {
                skillLevel++;
                OnUpgrade?.Invoke(1);
            }
        }
    }
}
