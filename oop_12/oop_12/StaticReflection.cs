using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace oop_12
{
    [Serializable]
    public static class StaticReflection
    {

        private static string filePath = "DB.txt";
        public static string GetPath
        {
            get
            {
                return filePath;
            }
        }
        public static string SetPath
        {
            set
            {
                filePath = value;
            }
        }

        

        private static StreamWriter File = null;

        

        private static void openFile()
        {
            if(filePath != null)
            File = new StreamWriter(filePath, true);
        }
        public static void closeFile()
        {
            if(File!=null)
            File.Close();
        }
        
        
        public static void GetAssembly(string assemlyName = "oop_12.exe")
        {
            openFile();
            Assembly assembly = Assembly.LoadFrom(assemlyName);
              
            File.WriteLine($"Assembly: {assembly}");
            closeFile();
        }

        public static void GetPublicConstructor(string className)
        {
            openFile();


            Type classData = Type.GetType(className);
            

            bool hasPublicConstructor = false;
            foreach(var item in classData.GetConstructors())
            {
                if(item.IsPublic)
                {
                    hasPublicConstructor = true;
                    break;
                }
            }
            File.WriteLine($"Class name: {className} - have public constructor: {hasPublicConstructor}");
            closeFile();
        }

        public static void GetPublicMethods(string className)
        {

            openFile();

            Type classData = Type.GetType(className);
            


            File.WriteLine($"Class: {className} public methods list:");
            
            foreach(var item in classData.GetMethods())
            {
                if (item.IsPublic)
                    File.WriteLine($"{item.Name}");
            }
            closeFile();
        }

        public static void GetFieldAndProps(string className)
        {
            Type classData = Type.GetType(className);
            openFile();

            File.WriteLine($"Fields and properties of class: {className}");


            foreach(var item in classData.GetFields())
                File.WriteLine($"Field: {item.Name}");
           
            foreach (var item in classData.GetProperties())
                File.WriteLine($"Properties: {item.Name}");
            closeFile();
        }

        public static void GetImplementedInterfaces(string className)
        {
            Type classData = Type.GetType(className);
            openFile();


            File.WriteLine($"Implemented interfaces in class: {className}");

            foreach (var item in classData.GetInterfaces())
                File.WriteLine($"Interface: {item.Name}");
            closeFile();
        }


        public static void GetMethodsByProps(string className)
        {
            Type classData = Type.GetType(className);
            openFile();

            string parm = Console.ReadLine();
            File.WriteLine($"Methods with parm: {parm} in class: {className}");

            foreach (var item in classData.GetMethods())
                foreach (var itemParm in item.GetParameters())
                    if (parm ==  itemParm.ParameterType.Name)
                        File.WriteLine($"Method: {item.Name}");
            closeFile();
        }


        public static void GetClassInvoke(string className, string methodName, string argPath)
        {
            

            Console.WriteLine($"Try to call method:{methodName} in class: {className}");

            Type classData = Type.GetType(className);

            var method = classData.GetMethod(methodName);
            if(method == null)
            {
                Console.WriteLine("Did'n find method...");
                return;
            }

            StreamReader streamReader = new StreamReader(argPath);

            object obj = Activator.CreateInstance(classData);
            string parm;
            while ((parm = streamReader.ReadLine()) != null)
            {
                if (method.GetParameters().Length != 0)
                    method.Invoke(obj, parm.Split(' '));
                else
                    method.Invoke(obj, new object[] { });
            }
            
        }

        public static object CreateType(string className)
        {

            return Activator.CreateInstance(Type.GetType(className));
        }
    }
}
