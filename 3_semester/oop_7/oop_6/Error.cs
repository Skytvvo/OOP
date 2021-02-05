using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    public class ZERO : DivideByZeroException
    {
        public ZERO(string message):base(message)
        {

        }
    }
    public class InvalidArguments: ArgumentException
    {
        public dynamic Arg
        {
            get;
            set;
        }

    public InvalidArguments(string message, dynamic arg):base(message)
        {
            this.Arg = arg;
        }
    }

    public class InvalidTypecast : Exception
    {
        public object invalidObj
        { get; set; }
        public InvalidTypecast(string message, object invalidObj):base(message)
        {
            this.invalidObj = invalidObj;
        }
    }
    


}
