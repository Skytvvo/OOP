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
        public Workout(string Name, int Cost, State healthMark) : base(Name, Cost,healthMark) { }
        public override string ToString()
        {

            return ($"{this.GetType()}, values: name - {this.data.name}, cost - {this.data.cost}, state - {this.healthMark}");
        }
        public override void FAQ()
        {
            Console.WriteLine("Hard exercise");
        }
    }
}
