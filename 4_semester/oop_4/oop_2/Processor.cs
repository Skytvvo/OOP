using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace oop_2
{

    

    [Serializable]
    [SelfValidation]
    public class Processor
    {

        public Bits Bits { get; set; }

        public Manufactur Manufactur { get; set; }

        public Power Power { get; set; }

        public Cache Cache { get; set; }

    }


    /*public class Processor
    {
        
        public enum processorBit
        {
            x32, x64
        }

        string manufacter;
        *//*[Required]
        [SelfValidation]*//*
        public string Manufactor
        {
            get
            {
                return this.manufacter;
            }
            set
            {
                this.manufacter = value;
            }
        }

        string series;
       *//* [Required]
        [SelfValidation]*//*
        public string Series
        {
            get
            {
                return this.series;
            }
            set
            {
                this.series = value;
            }
        }

        string model;
       *//* [Required]
        [SelfValidation]*//*
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value; 
            }
        }

        short cores;
       *//* [Required]
        [SelfValidation]*//*
        public short Cores
        {
            get
            {
                return this.cores;
            }
            set
            {
                this.cores = value;
            }
        }

        int frenquecy;
      *//*  [Required]
        [SelfValidation]*//*
        public int Frenquecy
        {
            get
            {
                return this.frenquecy;
            }
            set
            {
                this.frenquecy = value;
            }
        }

        processorBit bitArchitecture;
        *//*[Required]
        [SelfValidation]*//*
        public processorBit BitArchitecture
        {
            get
            {
                return this.bitArchitecture;
            }
            set
            {
                this.bitArchitecture = value;
            }
        }

        int L1;
       *//* [Required]
        [SelfValidation]*//*
        public int sizeL1
        {
            get
            {
                return this.L1;
            }
            set
            {
                this.L1 = value;
            }
        }

        int L2;
       *//* [Required]
        [SelfValidation]*//*
        public int sizeL2
        {
            get
            {
                return this.L2;
            }
            set
            {
                this.L2 = value;
            }
        }

        int L3;
      *//*  [Required]
        [SelfValidation]*//*
        public int sizeL3
        {
            get
            {
                return this.L3;
            }
            set
            {
                this.L3 = value;
            }
        }
        public Processor()
        {

        }
       

        
    }*/
}
