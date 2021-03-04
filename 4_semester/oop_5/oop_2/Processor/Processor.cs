using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using oop_2.StructurePattern;

namespace oop_2
{

    



    [Serializable]
    [SelfValidation]
    public class Processor : IProcessorUnite
    {
        public Processor()
        {

        }

        public Processor(Cache cache, Bits bits, Manufactur manufactur, Power power)
        {
            this.Bits = bits;
            this.Cache = cache;
            this.Manufactur = manufactur;
            this.Power = power;
        }

        public Bits Bits { get; set; }

        public Manufactur Manufactur { get; set; }

        public Power Power { get; set; }

        public Cache Cache { get; set; }

        public bool CheckProps()
        {
            if (Power.Frenquecy >=20000)
                return false;

            if (Power.Cores >= 256 && Cache.L3 < 4000)
                return false;
            if (Power.Cores == 1 && Power.Frenquecy == 9000)
                return false;
            if (Cache.L1 == 0)
                return false;
            if (Cache.L1 == 0 && Cache.L2 != 0)
                return false;

            return true;
        }
    }


}
