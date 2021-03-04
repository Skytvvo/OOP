using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public enum ComputerTypes
    {
        Server, workingStation, notebook, PC
    };

    public enum RamTypes
    {
        ddr1, ddr2, ddr3, ddr4, ddr5
    }

    public enum DriveTypes
    {
        ssd, hdd, shdd
    }
    [Serializable]
    public abstract class ComputerConfig
    {
        public ComputerConfig()
        {

        }
        public abstract void SetAttributes(ComputerTypes computerTypes, RamTypes ramTypes, DriveTypes driveTypes);
        
        public virtual ComputerTypes CType { get; set; }
        public virtual RamTypes RType { get; set; }
        public virtual DriveTypes DType { get; set; }
    }

    [Serializable]
    public abstract class ComputerHardware
    {
        public ComputerHardware()
        {

        }
        public abstract void SetAttributes(Processor processor, string videocard, int DriveSize);
        public abstract void SetPurchaseTime(string purchaseTime);
        public virtual Processor Processor { get; set; }
        public virtual string Videocard { get; set; }
        
        public virtual string PurchaseTime { get; set; }

        public virtual int DriveSize { get; set; }
    }

    
    public interface IFactory
    {
        ComputerConfig CreateConfig();
        ComputerHardware CreateHardware();
    }


}
