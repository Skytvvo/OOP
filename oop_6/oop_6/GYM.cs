using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oop_5
{
    public class GYM
    {
        private int budget;
        public int Budget
        {
            get
            {
                return this.budget;
            }
        }

        public GYM()
        {

        }
        public GYM(int budget)
        {
            while (budget <= 0)
            {
                Console.WriteLine("Invalid value, try again!");
                budget = Convert.ToInt32(Console.ReadLine());
            }

            this.budget = budget;
            _container = new List<Inventory>();
        }

        internal List<Inventory> _container;
        public Inventory this[int index]
        {
            get { return _container[index]; }
            set {
                Console.WriteLine($"Budget now:{CountItemsSum()}");
                 if (CountItemsSum() + value.data.cost > this.budget)
                {
                    Console.WriteLine("Sorry but you are over budget");
                    return;
                }
                else
                    _container[index] = value;
            }
        }
        public void Add(Inventory item)
        {
            if (CountItemsSum() + item.data.cost > this.budget)
            {
                Console.WriteLine("Sorry but you are over budget");
                return;
            }
            else
                _container.Add(item);

        }

        
       
        public void Delete(int index) => _container.RemoveAt(index);
        public void PrintToConsole() => _container.ForEach((Inventory item) => Console.WriteLine(item));
        private int CountItemsSum() => _container.Sum(item => item.data.cost);

    }
}
