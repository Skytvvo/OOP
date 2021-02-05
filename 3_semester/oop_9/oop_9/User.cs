using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace oop_9
{
    public delegate void WorkHandler(int duration);
    public delegate void UpgradeHandler(byte increaseSkillLevelOn);

    internal class User
    {
        //обработчик событий для OnUpgrade
        public static void upgradeEventHandler(byte increaseSkillLevelOn)
        {
            Console.WriteLine($"Skill was increased by {increaseSkillLevelOn} Lvl");
        }

        //обработчик событий для OnWork
        public static void workEventHandler(int duration)
        {

            Console.WriteLine("Working...");
            Console.WriteLine($"Wait {duration} ms");
            Thread.Sleep(duration);
            Console.WriteLine("Done!");
        }

    }

   
}
