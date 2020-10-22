using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    class Ball : Sport, CONFLICT_INTERFACE
    {
        public Ball(string Name, int Cost, State healthMark) : base(Name,Cost,healthMark) { }
        public override void FAQ()
        {
            Console.WriteLine("Sport exercises with ball");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Hello from ball");
            return base.GetHashCode();
        }

        public override string ToString()
        {

            return ($"{this.GetType()}, values: name - {this.data.name}, cost - {this.data.cost}, state - {this.healthMark}");
        }

        public Manufacturer Creator { get; set; }


         void CONFLICT_INTERFACE.CanMove()
         {
            Console.WriteLine("Hello from inteface");
         }

        public override void CanMove()
        {   
            Console.WriteLine("Hello from class");
        }
    }
}
