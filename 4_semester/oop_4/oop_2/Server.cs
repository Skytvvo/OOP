using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    [Serializable]

    public class ServerDefaultConfig : ComputerConfig
    {
        public override void SetAttributes(ComputerTypes computerTypes, RamTypes ramTypes, DriveTypes driveTypes)
        {
            this.CType = ComputerTypes.Server;
            this.RType = RamTypes.ddr5;
            this.DType = DriveTypes.shdd;
        }
    }
    [Serializable]

    public class ServerHardware : ComputerHardware
    {
        public override void SetAttributes(Processor processor, string videocard, int DriveSize)
        {
            this.Processor = processor;
            this.Videocard = videocard;
            this.DriveSize = 8256;
        }

        public override void SetPurchaseTime(string purchaseTime)
        {
            this.PurchaseTime = purchaseTime;
        }
    }
}
