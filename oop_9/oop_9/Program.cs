using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oop_9
{
    
    class Program
    {
        //обработчик событий для OnUpgrade
        static void upgradeEventHandler(byte increaseSkillLevelOn){
            Console.WriteLine($"Skill was increased by {increaseSkillLevelOn} Lvl");
        }

        //обработчик событий для OnWork
        static void workEventHandler(int duration){

            Console.WriteLine("Working...");
            Console.WriteLine($"Wait {duration} ms");
            Thread.Sleep(duration);
            Console.WriteLine("Done!");
        }
        public Action<string> ToUppercase = (string str) =>
            {
                Console.WriteLine(str.ToUpper());
            };
        static void Main(string[] args)
        {
            User User001 = new User("IlyaProGamer2002", 25);
            User001.OnWork += workEventHandler;
            User001.OnUpgrade += upgradeEventHandler;

            User User002 = new User("Jija", 77);
            User002.OnWork += workEventHandler;
            User002.OnUpgrade += upgradeEventHandler;

            User User003 = new User("Chucky", 27);
            User003.OnWork += workEventHandler;
            User003.OnUpgrade += upgradeEventHandler;

            User001.StartWork(2000);
            User002.StartWork(4000);
            User003.StartWork(6000);

            Action<string> process; 

            process = ProcessString.AddSubStr;
            process += ProcessString.DeleteSigns;
            process += ProcessString.DeleteSpace;
            process += ProcessString.ToUppercase;
            process += ProcessString.UpperFirstLetter;

            ProcessString.UseAction("some text, for example.", process);

            //аналогично Func
        }
    }
}
