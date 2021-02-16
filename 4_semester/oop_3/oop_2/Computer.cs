using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace oop_2
{
    [Serializable]
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
        [Required]
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
        [Required]
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
        [Required]
        [StringLength(50, MinimumLength = 3)]
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
        [Required]

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
        [Required]
        [Range(1, 99999)]
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
        [Required]

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
       

        string purchaseTime;
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string PurchaseTime
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

        public Computer(ComputerTypes type, Processor processor, string videocard, RamTypes ramType, int driveSize, DriveTypes driveType, string purchaseTime)
        {
            this.type = type;
            this.processor = processor;
            this.videocard = videocard;
            this.ramType = ramType;
            this.driveSize = driveSize;
            this.driveType = driveType;
            this.purchaseTime = purchaseTime;
        }

        public Computer()
        {

        }
    }
}
