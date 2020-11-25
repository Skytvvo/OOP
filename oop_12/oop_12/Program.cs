using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace oop_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string className = "oop_12.IR`1";
                StaticReflection.GetAssembly();
                StaticReflection.GetPublicConstructor(className);
                StaticReflection.GetPublicMethods(className);
                StaticReflection.GetFieldAndProps(className);
                StaticReflection.GetImplementedInterfaces(className);
                StaticReflection.GetMethodsByProps(className);
                StaticReflection.GetClassInvoke("oop_12.Message", "message", "argPath.txt");

                Message obj = (Message)StaticReflection.CreateType("oop_12.Message");
                obj.message("Created!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                StaticReflection.closeFile();
            }
        }
    }
}
