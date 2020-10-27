using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace oop_5
{
    abstract public  class Inventory
    {
        
        public enum State
            {
            None,
            New,
            Used,
            Broken
        }

        public State healthMark;


       public Inventory()
        {
            this.data.name = "Undefined";
            this.data.cost = 0;
            this.healthMark = State.None;
        }


        public struct Structure
        {
            public string name;
            public int cost;

            public Structure( string name, int cost)
            {
                this.name = name;
                Debug.Assert(cost > 0, "Cost can't be negative");
                this.cost = cost;
            }
        }

        public Structure data;

        public Inventory(string Name, int Cost, State healthMark)
        {
            data = new Structure(Name, Cost);
            this.healthMark = healthMark;
        }

        public override int GetHashCode()
        {
            if (this.data.cost == 0)
                throw new ZERO("Count-hash error");

            return (Convert.ToInt32(this.data.name)/this.data.cost);
        }
        public override string ToString()
        {

            return ($"{this.GetType()}, values: name - {this.data.name}, cost - {this.data.cost}, state - {this.healthMark}");
        }
        public virtual void FAQ()
        {
            Console.WriteLine("This item is part of inventory");
        }

        public virtual void PrintClassData(Object obj)
        {
            Debug.Assert(obj != null, "You cannot use empty object");
            Console.WriteLine($"Iventory - child data:{obj.GetType()}");
        }

    }
}
