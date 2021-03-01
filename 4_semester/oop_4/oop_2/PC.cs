using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    [Serializable]

    public class PCDefaultConfig : ComputerConfig
    {
        public override void SetAttributes(ComputerTypes computerTypes, RamTypes ramTypes, DriveTypes driveTypes)
        {
            this.CType = ComputerTypes.PC;
            this.DType = driveTypes;
            this.RType = ramTypes;
        }
    }
    [Serializable]

    public class PCHardware : ComputerHardware
    {
        public override void SetAttributes(Processor processor, string videocard, int DriveSize)
        {
            this.DriveSize = DriveSize;
            this.Videocard = videocard;
            this.Processor = processor;
        }

        public override void SetPurchaseTime(string purchaseTime)
        {
            this.PurchaseTime = purchaseTime;
        }
    }
}
