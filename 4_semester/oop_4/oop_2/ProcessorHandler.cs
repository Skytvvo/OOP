using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    public class ProcessorHandler
    {

        public Processor GetProcessor(ProcessorBuilder processorBuilder)
        {
            processorBuilder.CreateProcessor();

            processorBuilder.SetManufacter();
            processorBuilder.SetBits();
            processorBuilder.SetCache();
            processorBuilder.SetPower();

            return processorBuilder.Processor;
        }

    }
}
