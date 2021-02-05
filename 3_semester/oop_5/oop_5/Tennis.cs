using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    class Tennis : Ball
    {
        public Tennis(string Name) : base(Name) { }
        public override string ToString()
        {

            return ($"{this.GetType()}, values: {this.name}");
        }
        public override void FAQ()
        {
            Console.WriteLine("Sport for super reaction");
        }
    }
}
