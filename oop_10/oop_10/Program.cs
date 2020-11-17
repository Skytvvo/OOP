using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InternerResource<string> BY = new InternerResource<string>(4);
                BY.Add("Onliner");
                BY.Add("Kufar");
                BY.Add("TUT.by");
                BY.Add("4PDA");

                foreach (string item in BY)
                {
                    Console.WriteLine(item);
                }

                //===============
                Console.Write("\n========================\n\n");
                //===============
                BY.RemoveAt(3);
                BY.Insert(1, "VITALIK");

                foreach (string item in BY)
                {
                    Console.WriteLine(item);
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
