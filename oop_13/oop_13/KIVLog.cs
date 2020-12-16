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
        static string logPath = Directory.GetCurrentDirectory() + @"\UserActivity.log";
        


        static KIVLog()
        {

            StreamWriter OutFile = new StreamWriter(logPath, false);
            OutFile.WriteLine("User activity log protocol:");
            OutFile.Close();
        }
        static public void ListenUserActivity(MethodBase Method, FileInfo File, DateTime Time, string Path )
        {
            
           StreamWriter OutFile = new StreamWriter(Path, true);
            
            OutFile.WriteLine($"[{Time.TimeOfDay}]: User use {Method.Name} of {File.Name} from {File.Directory};");

            OutFile.Close();
        }
        static public void ListenUserActivity(MethodBase method, FileInfo File, DateTime Time)
        {
            ListenUserActivity(method, File, Time, logPath);
        }

        static public void ListenUserActivity(MethodBase method, FileInfo File)
        {
            ListenUserActivity(method, File, DateTime.Now); 
        }
    }
}
