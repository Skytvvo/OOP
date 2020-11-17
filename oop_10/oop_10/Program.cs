using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace oop_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //task 1
                InternerResource<string> BY = new InternerResource<string>(4);
                BY.Add("Onliner");
                BY.Add("Kufar");
                BY.Add("TUT.by");
                BY.Add("4PDA");

                foreach (string item in BY)
                {
                    Console.WriteLine(item);
                }

                //===============
                Console.Write("\n========================\n\n");
                //===============
                BY.RemoveAt(3);
                BY.Insert(1, "VITALIK");

                foreach (string item in BY)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(BY.Contains("VITALIK"));
                Console.WriteLine(BY.IndexOf("VITALIK"));
                Console.WriteLine("\n\n");
                //task 2
                ConcurrentDictionary<int, object> BD = new ConcurrentDictionary<int, Object>();

                BD.TryAdd(1,"Vitalik");
                BD.TryAdd(2, "Ilya");
                BD.TryAdd(3, "Denis");
                BD.TryAdd(4, "Geshka");
                BD.TryAdd(5, "Lera");
                BD.TryAdd(6, "Danya");

                Console.WriteLine("ConcurrentDictionary");
                foreach(var item in BD)
                {
                    Console.WriteLine($"ID: {item.Key}, Name: {item.Value} ");
                }
                Object Vitalik = null;
                Object Denis = null;
                BD.TryRemove(1, out Vitalik);
                BD.TryGetValue(3, out Denis);
                HashSet<object> HSDB = new HashSet<object>();
                
                foreach(var BDItem in BD)
                {
                    HSDB.Add(BDItem.Value);
                }

                Console.WriteLine("HashSet:");

                foreach(var HSBDItem in HSDB)
                {
                    Console.WriteLine(HSBDItem);
                }

                Console.WriteLine($"Contains {Vitalik} in HSBD: {HSDB.Contains(Vitalik)}");
                Console.WriteLine($"Contains {Denis} in HSBD: {HSDB.Contains(Denis)}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
