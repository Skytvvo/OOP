using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_5;

namespace oop_6
{
   static public class Controller
    {
        
        static public void SortInventory(GYM list) => list._container.Sort((A, B) => A.data.cost.CompareTo(B.data.cost));

        static public void FindFromRange(GYM list, int begin, int quantity)
        {
            if (begin + quantity > list._container.Count())
            {
                Console.WriteLine("Invalid value, try again");
                return;
            }
            Console.WriteLine("Result:");

            list._container.GetRange(begin, quantity).ForEach((Inventory item) => Console.WriteLine(item));
        }
    }
}
