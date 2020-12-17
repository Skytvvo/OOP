using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oop_13
{
    delegate void ActivityHandler(MethodBase method, FileInfo File);
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            KIVDiskInfo disk = new KIVDiskInfo(KIVLog.ListenUserActivity);
            disk.PrintValueOfFreeSpaceIn();
            disk.PrintFileSystem();
            disk.SummarizeData();

            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Green;

            KIVFileInfo file = new KIVFileInfo(KIVLog.ListenUserActivity);

            string path = @"D:\projects\labs\3-semester\KIV-2020\KIV-2020\kontrPrimer.txt";
            file.PrintPath(path);
            file.PrintTypeExtName(path);
            file.PrintCreationInfo(path);

            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Magenta;

            KIVDirInfo direct = new KIVDirInfo(KIVLog.ListenUserActivity);

            path = @"D:\projects\labs\3-semester\KIV-2020\KIV-2020\";

            direct.printFilesAmount(path);
            direct.PrintRootDirect(path);
            direct.PrintSubDirectories(path);
            direct.PrintTimeOfCreation(path);
            Thread.Sleep(2000);
            KIVFileManager manager = new KIVFileManager(KIVLog.ListenUserActivity, @"./KIVdirinfo.txt");
            manager.ManageCombination(@"D:\");
            manager.Taskb(@"D:\KIVFiles", @"D:\projects\labs\3-semester\инженерка", ".pdf");
            manager.CompressThis(@"D:\KIVFiles", @"D:\13LAB.zip");
            manager.Decompress(@"D:\13LAB.zip", @"D:\NEWFOLDER\");

            List<string> currentLines = new List<string>();
            using (StreamReader sw = new StreamReader(KIVLog.logPath))
            {
                string line;
                char[] separators = { '[', ']' };
                int size = DateTime.Now.TimeOfDay.ToString().Length;
                int counter = 0;
                while (!sw.EndOfStream)
                {
                    counter++;
                    line = sw.ReadLine();
                    if(Convert.ToDateTime(line.Substring(1, size)).Second < 20)
                    {
                        Console.WriteLine(line);
                    }
                    if(Convert.ToDateTime(line.Substring(1, size)).Hour-DateTime.Now.Hour <=1)
                    {
                        currentLines.Add(line);
                    }
                }
                Console.WriteLine($"Total lines: {counter}");
                sw.Close();
            }
            using (StreamWriter streamWriter = new StreamWriter(KIVLog.logPath,false))
            {
                currentLines.ForEach((line)=> {
                    streamWriter.WriteLine(line);
                });
                streamWriter.Close();
            }

        }
    }
}
