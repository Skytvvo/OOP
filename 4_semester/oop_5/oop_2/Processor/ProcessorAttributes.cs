using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public class Bits
    {
        public enum processorBit
        {
            x32, x64
        }

        public processorBit BitArchitecture
        {
            get; set;
        }

    }

    public class Manufactur
    {
        public string man
        {
            get; set;
        }

        public string Series
        {
            get; set;
        }

        public string Model
        {
            get; set;
        }

    }

    public class Power
    {
        public int Cores
        {
            get; set;
        }

        public int Frenquecy
        {
            get; set;
        }
    }

    public class Cache
    {
        public int L1
        {
            get; set;
        }

        public int L2
        {
            get; set;
        }

        public int L3
        {
            get; set;
        }
    }
}
