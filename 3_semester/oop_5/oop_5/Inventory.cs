using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
   public  class Inventory
    {
        public Inventory(string name)
        {
            this.name = name;
        }

        protected string name;

        public virtual string GetName
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {

            return $"{this.GetType()}, values: {this.name}";
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
