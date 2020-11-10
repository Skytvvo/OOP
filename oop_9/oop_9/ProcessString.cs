using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace oop_9
{
    internal class ProcessString
    {

        static public void ToUppercase(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        static public void DeleteSpace(string str)
        {            
            Console.WriteLine(String.Join("", str.Split(' '))); ;
        }

        static public void DeleteSigns(string str)
        {
            Console.WriteLine(String.Join("", str.Split(',','.',':',';')));
        }

        static public void AddSubStr(string str)
        {
            Console.WriteLine("Enter symbol");
            string sym = Convert.ToString(Console.Read());

            Console.WriteLine(String.Concat(str,sym));
        }

        static public void UpperFirstLetter(string str)
        {
            Char.ToUpper(str[0]);
            Console.WriteLine(str);
        }

        static public void UseAction(string str, Action<string> delAct)
        {
            delAct?.Invoke(str);
        }
    }
}
