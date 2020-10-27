using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_6;

namespace oop_5
{
    public class Printer : Inventory
    {
        public Printer(string Name,int Cost, State healthMark) : base(Name,Cost,healthMark) { } 
        public override void PrintClassData(Object obj)
        {
            if(!(obj is Inventory))
            {
                throw new InvalidTypecast("Error-cast in printer",obj);
            }

            Console.WriteLine($"---------------\n" +
                $"Type:{obj.GetType()}\n" +
                $"ToString():{obj.ToString()}\n");
        }

    }
}
