using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_14
{
    [Serializable]
    public class Sport : Inventory
    {
        [NonSerialized]
        public string noSeriazable = "nope";

        public string yesSeriazable = "oh,my";
        public override string ToString()
        {

            return ($"{this.GetType()}, values: {this.name}");
        }
        public Sport(string Name) : base(Name) { }
        public Sport() : base("Me") { }
    }
}
