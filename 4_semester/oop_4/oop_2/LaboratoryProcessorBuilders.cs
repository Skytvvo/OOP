using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public class PCProcessorBuilder : ProcessorBuilder
    {
        public override void SetBits(Bits bits)
        {
            this.Processor.Bits = bits; 
        }

        public override void SetCache(Cache cache)
        {
            this.Processor.Cache = cache;
        }

        public override void SetManufacter(Manufactur manufactur)
        {
            this.Processor.Manufactur = manufactur;
        }

        public override void SetPower(Power power)
        {
            this.Processor.Power = power;
        }
    }

    public class ServerProcessorBuilder : ProcessorBuilder
    {
        public override void SetBits(Bits bits)
        {
            this.Processor.Bits = new Bits { BitArchitecture = Bits.processorBit.x64 };
        }

        public override void SetCache(Cache cache)
        {
            this.Processor.Cache = cache;
        }

        public override void SetManufacter(Manufactur manufactur)
        {
            this.Processor.Manufactur = new Manufactur { man="Intel", Model="Xeon", Series="Server"};
        }

        public override void SetPower(Power power)
        {
            this.Processor.Power = power;
        }
    }

    public class LaptopProcessorBuilder : ProcessorBuilder
    {
        public override void SetBits(Bits bits)
        {
            this.Processor.Bits = bits;
        }

        public override void SetCache(Cache cache)
        {
            this.Processor.Cache = cache;
        }

        public override void SetManufacter(Manufactur manufactur)
        {
            this.Processor.Manufactur = manufactur;
        }

        public override void SetPower(Power power)
        {
            this.Processor.Power = power;
        }
    }

    public class WorkStationProcessorBuilder : ProcessorBuilder
    {
        public override void SetBits(Bits bits)
        {
            this.Processor.Bits = new Bits { BitArchitecture= Bits.processorBit.x64 };
        }

        public override void SetCache(Cache cache)
        {
            this.Processor.Cache = cache;
        }

        public override void SetManufacter(Manufactur manufactur)
        {
            this.Processor.Manufactur = new Manufactur {  
                man="Intel",
                Model="Workstation processor",
                Series="Ice-Lake"
            };
        }

        public override void SetPower(Power power)
        {
            this.Processor.Power = power;
        }
    }
}
