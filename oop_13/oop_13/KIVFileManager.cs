using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Compression;

namespace oop_13
{
    internal class KIVFileManager
    {
        string path;
        event ActivityHandler ManageListener;

        FileInfo classInfo = new FileInfo(typeof(KIVFileManager).AssemblyQualifiedName);

        public KIVFileManager(ActivityHandler method, string path)
        {
            ManageListener += method;
            this.path = path;
        }

        public void ManageCombination(string path)
        {
            ManageListener(MethodInfo.GetCurrentMethod(), classInfo);
            if(!Directory.Exists(path))
            {
                Console.WriteLine("Incorrect path");
                return;
            }
            List<string> BDDirectories = new List<string>();
            GetAllDirectories(path, ref BDDirectories);
            Console.WriteLine(BDDirectories.Count);
            
            CreateRepos(this.path);
            
            
            
                
                        StreamWriter fw = new StreamWriter(this.path);
                foreach(var item in BDDirectories)
                {
                    try
                    {

                        foreach (var fileinfo in Directory.GetFiles(item))
                        {
                        fw.WriteLine(fileinfo);
                        }
                    
                }
                    catch
                    {
                        continue;
                    }
                }
                
                        fw.Close();
                    if (!File.Exists(path + "copy.txt"))
                        File.Copy(this.path, path + "copy.txt");
           
     
        }

        void GetAllDirectories(string path,ref List<string> BDDirectories)
        {
            try
            {   
                foreach (var direct in Directory.GetDirectories(path))
                {
                   
                    BDDirectories.Add(direct);
                    GetAllDirectories(direct, ref BDDirectories);
                }
            }
            catch
            {
                return;
            }
        }

        void CreateRepos(string path)
        {
            ManageListener(MethodInfo.GetCurrentMethod(), classInfo);
            FileInfo newFile = new FileInfo(path);
            if(!newFile.Exists)
            newFile.Create();
            
            
        }
        void deleteFile(string file)
        {
            File.Delete(file);
        }
        public void CompressThis(string folder, string zipLocate)
        {
            ManageListener(MethodInfo.GetCurrentMethod(), classInfo);
            if (File.Exists(zipLocate))
                return;
            ZipFile.CreateFromDirectory(folder, zipLocate);
        }
        public void Decompress(string zipFile, string folderLocate)
        {
            ManageListener(MethodInfo.GetCurrentMethod(), classInfo);
            if (Directory.Exists(folderLocate))
                return;
            ZipFile.ExtractToDirectory(zipFile, folderLocate);
        }
        public void Taskb(string path, string newPath, string ext)
        {
            
            ManageListener(MethodInfo.GetCurrentMethod(), classInfo);
            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (!Directory.Exists(newPath))
                return;

            DirectoryInfo oldPath = new DirectoryInfo(newPath);
            FileInfo[] files = oldPath.GetFiles();
            foreach(var item in files)
            {
                if (item.Name.Contains(ext) && !File.Exists(path +@"\"+ item.Name))
                {
                    File.Move(item.FullName, path + @"\" + item.Name);
                }
            }
        }

    }
}
