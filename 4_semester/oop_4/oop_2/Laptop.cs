using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    [Serializable]

    public class LaptopDefaultConfig : ComputerConfig
    {
       

        public override void SetAttributes(ComputerTypes computerTypes, RamTypes ramTypes, DriveTypes driveTypes)
        {
            this.CType = ComputerTypes.notebook;
            this.DType = driveTypes;
            this.RType = ramTypes;
        }
    }
    [Serializable]

    public class LaptopHardware : ComputerHardware
    {
        public override void SetAttributes(Processor processor, string videocard, int DriveSize)
        {
            this.DriveSize = DriveSize;
            this.Processor = processor;
            this.Videocard = videocard;
        }

        public override void SetPurchaseTime(string purchaseTime)
        {
            this.PurchaseTime = purchaseTime;
        }
    }
}
