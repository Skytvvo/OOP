using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    class Tools : Inventory
    {
        public Tools(string Name,int Cost, State healthMark) : base(Name,Cost,healthMark) { }
        public override string ToString()
        {

            return ($"{this.GetType()}, values: name - {this.data.name}, cost - {this.data.cost}, state - {this.healthMark}");
        }
        public override void FAQ()
        {
            Console.WriteLine("Tools for sport inventory");
        }
    }
}
