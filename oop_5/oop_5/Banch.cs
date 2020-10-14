using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    sealed class Banch : Tools
    {
        public Banch(string Name) : base(Name) { }

        public override string ToString()
        {

            return ($"{this.GetType()}, values: {this.name}");
        }
        public override void FAQ()
        {
            Console.WriteLine("You can rest here");
        }
    }
}
