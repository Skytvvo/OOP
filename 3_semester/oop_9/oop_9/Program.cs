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
       
        public Action<string> ToUppercase = (string str) =>
            {
                Console.WriteLine(str.ToUpper());
            };
        static void Main(string[] args)
        {
            Human User001 = new Human("IlyaProGamer2002", 25);
            User001.OnWork += User.workEventHandler;
            User001.OnUpgrade += User.upgradeEventHandler;

            Human User002 = new Human("Jija", 77);
            User002.OnWork += User.workEventHandler;
            User002.OnUpgrade += User.upgradeEventHandler;

            Human User003 = new Human("Chucky", 27);
            User003.OnWork += User.workEventHandler;
            User003.OnUpgrade += User.upgradeEventHandler;

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
