using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using oop_6;

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
            Console.WriteLine("Enter budget");
            try
            {
                int money = Convert.ToInt32(Console.ReadLine());
                if (money < 0)
                    throw new InvalidArguments("Negative budget", money);
                int tax = Convert.ToInt32(Console.ReadLine());

               
                if (tax < 0)
                    throw new InvalidArguments("Negative tax", tax);

                uint budget = Convert.ToUInt32(money) * (100 - Convert.ToUInt32(tax));

                GYM container = new GYM(budget);


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

                Controller.FindFromRange(container, 2, 2);
            }
            catch(OutOfMemoryException e)
            {
                Console.WriteLine($"Memory exception:{e.Message}");
            }
            catch(InvalidArguments e)
            {
                Console.WriteLine($"Invalid arguments detected\n" +
                    $"Object:{e.Arg}\n" +
                    $"Message:{e.Message}");
            }
            catch(InvalidTypecast e)
            {
                Console.WriteLine($"Can't cast type:\n" +
                    $"object type: {e.invalidObj.GetType()}\n" +
                    $"Error message: {e.Message}");
            }
            catch(ZERO e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);   
            }
            catch
            {
                Console.WriteLine($"Exception");
            }
            finally
            {
                Console.WriteLine("Debug completed");
            }
        }
    }
}
