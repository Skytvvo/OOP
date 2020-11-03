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

namespace oop4
{
    
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                    
                LinkedList<Inventory,Sport> Listing = new LinkedList<Inventory,Sport>();
                
                Sport hard = new Sport("Football", 5000, Inventory.State.New);
                Sport easy = new Sport("Athletics", 25, Inventory.State.New);

                Listing.Add(hard);
                Listing.Add(easy);
                Listing.Add(hard);
                Listing.Add(easy);
                Listing.Add(easy);
                Listing.View();

                Listing.Delete(hard);

                Listing.View();

                Console.WriteLine("\n============================\n");

                LinkedList<Inventory, long> linkedList = new LinkedList<Inventory, long>();
                //Call methods to trigger an exception

                ClassWriter<Inventory, Sport>.WriteData(Listing);
                LinkedList<Inventory, Sport> copy = ClassWriter<Inventory, Sport>.ReadData(Listing.Path);

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
