using System;
using System.Collections.Generic;
using System.Linq;
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
        public KIVFileInfo(ActivityHandler method)
        {
            this.fileInfoActivity += method;
        }

        public void PrintInfoByName(string fileName)
        {

        }

    }
}
