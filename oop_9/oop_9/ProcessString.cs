using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace oop_9
{
    static internal class ProcessString
    {

        static public Action<string> ToUppercase = (string str) =>
        {
            Console.WriteLine(str.ToUpper());
        };

        static public Action<string> DeleteSpace = (string str) =>
        {
            Console.WriteLine(String.Join("", str.Split(' ')));
        };

        static public Action<string> DeleteSigns = (string str) =>
        {
            Console.WriteLine(String.Join("", str.Split(',', '.', ':', ';')));
        };

        static public Action<string> AddSubStr = (string str) =>
        {
            Console.WriteLine("Enter symbol");
            string sym = Convert.ToString(Console.ReadLine());

            Console.WriteLine(String.Concat(str, sym));
        };

        static public Action<string> UpperFirstLetter = (string str) =>
        {
            Char.ToUpper(str[0]);
            Console.WriteLine(str);
        };

        static public void UseAction(string str, Action<string> delAct)
        {
            delAct?.Invoke(str);
        }
    }
}
