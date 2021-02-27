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

        public void CreateProcessor()
        {
            Processor = new Processor();
        }

        public abstract void SetManufacter();

        public abstract void SetBits();

        public abstract void SetPower();

        public abstract void SetCache();


    }
}
