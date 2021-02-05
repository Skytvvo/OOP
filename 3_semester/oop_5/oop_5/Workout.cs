using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    class Workout : Sport
    {
        public override void CanMove()
        {
            Console.WriteLine("This item can't move");
        }
        public Workout(string Name) : base(Name) { }
        public override string ToString()
        {

            return ($"{this.GetType()}, values: {this.name}");
        }
        public override void FAQ()
        {
            Console.WriteLine("Hard exercise");
        }
    }
}
