using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    [Serializable]

    public class WorkStationDefaultConfig : ComputerConfig
    {
        public WorkStationDefaultConfig()
        {

        }
        public override void SetAttributes(ComputerTypes computerTypes, RamTypes ramTypes, DriveTypes driveTypes)
        {
            this.CType = ComputerTypes.workingStation;
            this.DType = driveTypes;
            this.RType = ramTypes;
        }
    }
    [Serializable]

    public class WorkStationHardware : ComputerHardware
    { 
        public WorkStationHardware()
        {

        }
        public override void SetAttributes(Processor processor, string videocard, int DriveSize)
        {
            this.DriveSize = 4096;
            this.Processor = processor;
            this.Videocard = videocard;
        }

        public override void SetPurchaseTime(string purchaseTime)
        {
            this.PurchaseTime = purchaseTime;
        }
    }
}
