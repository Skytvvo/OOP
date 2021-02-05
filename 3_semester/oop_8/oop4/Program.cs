using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.ComponentModel;
using System.Diagnostics;

namespace oop4
{
    
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                    
                LinkedList<Inventory> Listing = new LinkedList<Inventory>();

                Inventory cleaningTools = new Inventory("Tools for clean", 150, Inventory.State.New);

                Inventory sportInventory = new Inventory("Inventory for football", 578, Inventory.State.Used);

                Inventory athleticTools = new Inventory("Light athletic inventory", 269, Inventory.State.Used);

                Listing.Add(cleaningTools);
                Listing.Add(sportInventory);
                Listing.Add(athleticTools);

                Listing.Delete(sportInventory);

                Listing.View();

                Listing.Add(sportInventory);

                Console.WriteLine("\n============================\n");

                

                ClassWriter<Inventory>.WriteData(Listing);
                LinkedList<Inventory> copy = ClassWriter<Inventory>.ReadData(Listing.Path);

                copy.View();


            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong\n" +
                    $"{e.Message}");
            }
            finally
            {
                Console.WriteLine($"Finally block");
            }

        }
    }
}
