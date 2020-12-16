using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_13
{
    delegate void ActivityHandler(MethodBase method, FileInfo File);
    class Program
    {
        static void Main(string[] args)
        {
            
            KIVDiskInfo disk = new KIVDiskInfo(KIVLog.ListenUserActivity);
            disk.PrintValueOfFreeSpaceIn();
            disk.PrintFileSystem();
            disk.SummarizeData();


        }
    }
}
