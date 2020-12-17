using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_13
{
    internal class KIVDirInfo
    {
        event ActivityHandler dirInfoActivity;
        public ActivityHandler DirInfoActivity;

        FileInfo classInfo = new FileInfo(typeof(KIVDirInfo).FullName);

        public KIVDirInfo(ActivityHandler method)
        {
            dirInfoActivity += method;
        }

        public void printFilesAmount(string path)
        {
            dirInfoActivity(MethodInfo.GetCurrentMethod(), classInfo);
            if(!Directory.Exists(path))
            {
                Console.WriteLine($"Incorrect path {path}");
                return;
            }
            string[] Files = Directory.GetFiles(path);
            foreach(var item in Files)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintTimeOfCreation(string path)
        {
            dirInfoActivity(MethodInfo.GetCurrentMethod(), classInfo);
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"Incorrect path {path}");
                return;
            }
            Console.WriteLine($"Time of creation {Directory.GetCreationTimeUtc(path)}");
        }

        public void PrintSubDirectories(string path)
        {
            dirInfoActivity(MethodInfo.GetCurrentMethod(), classInfo);
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"Incorrect path {path}");
                return;
            }

            Console.WriteLine($"Amount of directories: {Directory.GetDirectories(path).Length}");
        }

        public void PrintRootDirect(string path)
        {
            dirInfoActivity(MethodInfo.GetCurrentMethod(), classInfo);
            if (!Directory.Exists(path))
            {
                Console.WriteLine($"Incorrect path {path}");
                return;
            }

            Console.WriteLine($"Parent direct's:{Directory.GetParent(path).GetDirectories().Length}");
        }


    }
}
