using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public class Computer
    {
        public enum ComputerTypes {
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

        ComputerTypes type;
        public ComputerTypes Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        Processor processor;
        public Processor _Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                this.processor = value;
            }
        }

        string videocard;
        public string Videocard
        {
            get
            {
                return this.videocard;
            }
            set
            {
                this.videocard = value;
            }
        }

        RamTypes ramType;
        public RamTypes TypeOfRam
        {
            get
            {
                return this.ramType;
            }
            set
            {
                this.ramType = value;
            }
        }


        int driveSize;
        public int DriveSize
        {
            get
            {
                return this.driveSize;
            }
            set
            {
                this.driveSize = value;
            }
        }

        DriveTypes driveType;
        public DriveTypes DriveType
        {
            get
            {
                return this.driveType;
            }
            set
            {
                this.driveType = value;
            }
        }

        DateTime purchaseTime;
        public DateTime PurchaseTime
        {
            get
            {
                return this.purchaseTime;
            }
            set
            {
                this.purchaseTime = value;
            }

        }

        public Computer(ComputerTypes type, Processor processor, string videocard, RamTypes ramType, int driveSize, DriveTypes driveType, DateTime purchaseTime)
        {
            this.type = type;
            this.processor = processor;
            this.videocard = videocard;
            this.ramType = ramType;
            this.driveSize = driveSize;
            this.driveType = driveType;
            this.purchaseTime = purchaseTime;
        }
    }
}
