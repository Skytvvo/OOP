using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public class Processor
    {
        

        string manufacter;
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

        byte bitArchitecture;
        public byte BitArchitecture
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

        public Processor(string manufacter, string series, string model, short cores,int frenquecy, byte bitArchitecture, int L1, int L2, int L3)
        {
            this.manufacter = manufacter;
            this.series = series;
            this.model = model;
            this.cores = cores;
            this.frenquecy = frenquecy;
            this.bitArchitecture = bitArchitecture;
            this.L1 = L1;
            this.L2 = L2;
            this.L3 = L3;
        }

    }
}
