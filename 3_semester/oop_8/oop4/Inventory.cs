using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    
    [Serializable] public class Inventory
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


        [Serializable] public struct Structure
        {
            public string name;
            public int cost;

            public Structure(string name, int cost)
            {
                this.name = name;
                this.cost = cost;
            }
        }

        public Structure data;

        public Inventory(string Name, int Cost, State healthMark)
        {
            data = new Structure(Name, Cost);
            this.healthMark = healthMark;
        }

        public override string ToString()
        {

            return ($"{this.GetType()}, values: name - {this.data.name}, cost - {this.data.cost}, state - {this.healthMark}");
        }
        public virtual void FAQ()
        {
            Console.WriteLine("This item is part of inventory");
        }

        public virtual void PrintClassData(Inventory obj)
        {
            Console.WriteLine($"Iventory - child data:{obj.GetType()}");
        }

    }
}
