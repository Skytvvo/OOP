using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public class ServerProcessorBuilder : ProcessorBuilder
    {
        public override void SetBits()
        {
            this.Processor.Bits = new Bits { BitArchitecture = Bits.processorBit.x64 };
        }

        public override void SetCache()
        {
            this.Processor.Cache = new Cache { L1 = 128, L2 = 512, L3 = 4096 };
        }

        public override void SetManufacter()
        {
            this.Processor.Manufactur = new Manufactur { man = "Intel", Model = "xeon", Series = "Ice-Lake" };
        }

        public override void SetPower()
        {
            this.Processor.Power = new Power { Cores = 8, Frenquecy = 4900 };
        }
    }

    public class PCProcessorBuilder : ProcessorBuilder
    {
        public override void SetBits()
        {
            this.Processor.Bits = new Bits { BitArchitecture = Bits.processorBit.x64 };
        }

        public override void SetCache()
        {
            this.Processor.Cache = new Cache { L1 = 128, L2 = 512, L3 = 4096 };
        }

        public override void SetManufacter()
        {
            this.Processor.Manufactur = new Manufactur { man = "Intel", Model = "xeon", Series = "Ice-Lake" };
        }

        public override void SetPower()
        {
            this.Processor.Power = new Power { Cores = 8, Frenquecy = 4900 };
        }
    }

    public class LaptopProcessorBuilder : ProcessorBuilder
    {
        public override void SetBits()
        {
            this.Processor.Bits = new Bits { BitArchitecture = Bits.processorBit.x64 };
        }

        public override void SetCache()
        {
            this.Processor.Cache = new Cache { L1 = 128, L2 = 512, L3 = 4096 };
        }

        public override void SetManufacter()
        {
            this.Processor.Manufactur = new Manufactur { man = "Intel", Model = "xeon", Series = "Ice-Lake" };
        }

        public override void SetPower()
        {
            this.Processor.Power = new Power { Cores = 8, Frenquecy = 4900 };
        }
    }
    public class WorkingStationProcessorBuilder : ProcessorBuilder
    {
        public override void SetBits()
        {
            this.Processor.Bits = new Bits { BitArchitecture = Bits.processorBit.x64 };
        }

        public override void SetCache()
        {
            this.Processor.Cache = new Cache { L1 = 128, L2 = 512, L3 = 4096 };
        }

        public override void SetManufacter()
        {
            this.Processor.Manufactur = new Manufactur { man = "Intel", Model = "xeon", Series = "Ice-Lake" };
        }

        public override void SetPower()
        {
            this.Processor.Power = new Power { Cores = 8, Frenquecy = 4900 };
        }
    }

}
