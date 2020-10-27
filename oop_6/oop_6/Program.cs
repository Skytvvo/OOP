using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using oop_6;

namespace oop_5
{
    public interface IComparable
    {
        int CompareTo(object o);
    }

    public interface CONFLICT_INTERFACE
    {
            void CanMove();
    }

    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Enter budget");

            GYM container = new GYM(Convert.ToInt32(Console.ReadLine()));
           

            Ball ball = new Ball("Pro-Universal", 30, Inventory.State.Used);
            Basketball basketball = new Basketball("Common-street", 8, Inventory.State.Used);
            Banch banch = new Banch("Level up for yourself", 79, Inventory.State.Used);
            Bars bars = new Bars("Some text", 60, Inventory.State.New);
            Ball ball1 = new Ball("asd", 2000, Inventory.State.New);


            container.Add(ball);
            container.Add(basketball);
            container.Add(banch);
            container.Add(bars);

            

            container.PrintToConsole();


            Controller.SortInventory(container);

            Console.WriteLine("===================================================");

            container.PrintToConsole();

            Controller.FindFromRange(container, 2,2);
        }
    }
}
