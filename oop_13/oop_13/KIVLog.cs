using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_13
{
    
    static internal class KIVLog
    {
        static public void ListenUserActivity(MethodInfo Method, FileInfo File, DateTime Time, string Path )
        {
            StreamWriter OutFile = new StreamWriter(Path, true);

            OutFile.WriteLine($"[{Time.Date}]: User use {Method.Name} from {File.FullName};");

            OutFile.Close();
        }
        static public void ListenUserActivity(MethodInfo method, FileInfo File, DateTime Time)
        {
            ListenUserActivity(method, File, Time, Directory.GetCurrentDirectory() + @"\UserActivity.log");
        }

        static public void ListenUserActivity(MethodInfo method, FileInfo File)
        {
            ListenUserActivity(method, File, DateTime.Now);
        }
    }
}
