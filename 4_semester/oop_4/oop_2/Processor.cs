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


}
