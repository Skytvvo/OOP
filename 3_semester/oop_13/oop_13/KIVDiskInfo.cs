using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace oop_13
{
    internal class KIVDiskInfo
    {
        private  event ActivityHandler activityListener;
        public ActivityHandler ActivityListener
        {
            set
            {
                activityListener = value;
            }
        }
        FileInfo dataOfClass = new FileInfo(typeof(KIVDiskInfo).FullName);
        public KIVDiskInfo(ActivityHandler method)
        {
            activityListener += method;
        }

        public void PrintValueOfFreeSpaceIn()
        {
            activityListener(MethodInfo.GetCurrentMethod(), this.dataOfClass);
            
            foreach(var Drive in DriveInfo.GetDrives())
            {
                if(Drive.DriveType == DriveType.Fixed)
                    Console.WriteLine($"{Drive.Name} has {Decimal.Round(Convert.ToDecimal(Drive.AvailableFreeSpace/Math.Pow(10,9)),1)} GB of free space");
            }
        }

        public void PrintFileSystem()
        {
            activityListener(MethodInfo.GetCurrentMethod(), this.dataOfClass);
            foreach(var Drive in DriveInfo.GetDrives())
            {
                Console.WriteLine($"{Drive.Name} has {Drive.DriveFormat} format");
            }
        }

        public void SummarizeData()
        {
            activityListener(MethodInfo.GetCurrentMethod(), this.dataOfClass);
            decimal freeSpace = 0;
            decimal totalSpace = 0;
            foreach(var Drive in DriveInfo.GetDrives())
            {
                freeSpace = Decimal.Round(Convert.ToDecimal(Drive.AvailableFreeSpace / Math.Pow(10, 9)), 1);
                totalSpace = Decimal.Round(Convert.ToDecimal(Drive.TotalSize / Math.Pow(10, 9)), 1);
                Console.WriteLine($"{Drive.Name} - total: {totalSpace}, free: {freeSpace}, label: {Drive.VolumeLabel}");
            }
        }
    }
}
