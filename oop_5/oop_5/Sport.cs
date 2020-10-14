using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    abstract class Sport : Inventory
    {
        public abstract void CanMove();
        public override string ToString()
        {

            return ($"{this.GetType()}, values: {this.name}");
        }
        public Sport(string Name) : base(Name) { }
    }
}
