using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public abstract class ProcessorBuilder
    {
        public Processor Processor { get; private set; }

        public ProcessorBuilder()
        {
            Processor = new Processor();
        }

        public abstract void SetManufacter( Manufactur manufactur );

        public abstract void SetBits( Bits bits );

        public abstract void SetPower( Power power );

        public abstract void SetCache( Cache cache );


    }
}
