using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace oop_5
{
    class Basketball : Ball
    {



        public Basketball(string Name,int Cost, State healthMark) : base(Name,Cost,healthMark) { }
        public override string ToString()
        {

            return ($"{this.GetType()}, values: name - {this.data.name}, cost - {this.data.cost}, state - {this.healthMark}");
        }
        public override void FAQ()
        {
            Console.WriteLine("Sport for tall guys");
        }
    }
}
