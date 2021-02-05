using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_13
{
    internal class KIVFileInfo
    {
        event ActivityHandler fileInfoActivity;
        public ActivityHandler FileInfoActivity
        {
            set
            {
                this.fileInfoActivity = value;
            }
        }
        FileInfo dataOfClass = new FileInfo(typeof(KIVFileInfo).FullName);
        public KIVFileInfo(ActivityHandler method)
        {
            this.fileInfoActivity += method;
        }

        public void PrintPath(string path)
        {
            fileInfoActivity(MethodInfo.GetCurrentMethod(), dataOfClass);

            FileInfo currentFile = new FileInfo(path);
            if(!this.checkForExist(currentFile))
                return;
            
            Console.WriteLine($"For file from: {path} path is {currentFile.FullName}");
        }

        public void PrintTypeExtName(string path)
        {
            fileInfoActivity(MethodInfo.GetCurrentMethod(), dataOfClass);

            FileInfo currentFile = new FileInfo(path);
            if (!this.checkForExist(currentFile))
                return;
            Console.WriteLine($"Size: {currentFile.Length}, extension: {currentFile.Extension}, name: {currentFile.Name}");
        }

        public void PrintCreationInfo(string path)
        {
            fileInfoActivity(MethodInfo.GetCurrentMethod(), dataOfClass);

            FileInfo currentFile = new FileInfo(path);
            if (!this.checkForExist(currentFile))
                return;

            Console.WriteLine($"File was created in: {currentFile.CreationTimeUtc}, edited: {currentFile.LastAccessTimeUtc}");
        }
        private bool checkForExist(FileInfo file)
        {
            if (!file.Exists)
            {
                Console.WriteLine($"File does not exist");
                return false;
            }
            return true;
        }
    }
}
