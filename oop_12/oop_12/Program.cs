using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Threading;

namespace oop_12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            p.StartInfo.FileName = @"cmd";
            p.StartInfo.Arguments = "";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            p.StandardInput.WriteLine(@"cd /D c:\");
            p.StandardInput.WriteLine(@"cd C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools");
            p.StandardInput.WriteLine(@"VsDevCmd.bat");
            p.StandardInput.WriteLine(@"cd /d d:\");
            p.StandardInput.WriteLine(@"cd D:\projects\labs\3-semester\repositories\фыв\cerf\AsmExecute");
            p.StandardInput.WriteLine(@"ml /c /Cp /coff ASM.asm");
            Console.ReadKey();
            Thread.Sleep(4000);
            p.WaitForExit();
        }
    }
}
