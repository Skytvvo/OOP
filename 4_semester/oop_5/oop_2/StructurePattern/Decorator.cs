using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2.StructurePattern
{
   public abstract class ProcessorDecorator : Processor
    {
        protected Processor Processor;

        public ProcessorDecorator(Manufactur manufactur, Processor processor)
            :base(processor.Cache, processor.Bits, manufactur, processor.Power)
        {
            this.Processor = processor;
        }

    }

    public class OC_Processor : ProcessorDecorator
    {
        public OC_Processor(Processor processor)
            : base(new Manufactur {
                man = processor.Manufactur.man + " OC",
                 Model = processor.Manufactur.Model + " XT",
                  Series = processor.Manufactur.Series + " Extreme"
            }, processor)
        {
        }
    }

}
