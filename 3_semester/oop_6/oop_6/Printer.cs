﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    public class Printer : Inventory
    {
        public Printer(string Name,int Cost, State healthMark) : base(Name,Cost,healthMark) { } 
        public override void PrintClassData(Inventory obj)
        {
            Console.WriteLine($"---------------\n" +
                $"Type:{obj.GetType()}\n" +
                $"ToString():{obj.ToString()}\n");
        }

    }
}
