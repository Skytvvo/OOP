using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    public interface CONFLICT_INTERFACE
    {
            void CanMove();
    }

    class Program
    {
       

        static void Main(string[] args)
        {
            Basketball basketball = new Basketball("Winner");
            basketball.Creator = new Belarus("BelBallInc", "Minsk");

            Basketball basketball1 = new Basketball("Fire");
            basketball1.Creator = new Russia("RusGovCare","Moscow");

            Ball ball = new Ball("FF");
            Tools tools = new Tools("pickaxe");
            Inventory inventory = ball as Inventory;
            
            ball.CanMove();
            ((CONFLICT_INTERFACE)ball).CanMove();

            Ball ball1 = (Ball)inventory;

            Inventory inventory1 = ball;
            Inventory inventory2 = (Inventory)ball;
            Object obj = ball;
            ball1 = (Ball)obj;

            Console.WriteLine($"(as) ball to iventory :{ball as Inventory}");
            Console.WriteLine($"(as) inventory to ball :{inventory as Ball}");

            //Can't do it
            //Console.WriteLine($"ball to tools :{ball as Tools}");

            Console.WriteLine($"(is) tools to ball :{tools is Ball}");
            Console.WriteLine($"(is and interface)ball to interface:{ball is CONFLICT_INTERFACE}");
            Console.WriteLine($"(is and interface)tools to interface:{tools is CONFLICT_INTERFACE}");
            Console.WriteLine($"(as and interface)ball to interface:{ball as CONFLICT_INTERFACE}");
            
            Console.WriteLine(ball.ToString());

            Printer printer = new Printer("New");

            Inventory[] children = new Inventory[] { inventory, ball, tools, printer, new Bars("Bars"), new Banch("Banch") };

            foreach(var child in children)
            {
                printer.PrintClassData(child);
            }


        }
    }
}
