using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    
    public interface Manufacturer
    {
        string GetCompany { get; set; }

        string GetLocation { get; set; }

        void Specialization();
    }

    public class Belarus : Manufacturer
    {
        public Belarus(string company, string location)
        {
            this.company = company;
            this.location = location;
        }

        protected string company;
        protected string location;



        public string GetCompany {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public string GetLocation { 
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }
        
        public void Specialization()
        {
            Console.WriteLine("We can create balls for basketball");
        }
    }

    public class Russia : Manufacturer
    {
        public Russia(string company, string location)
        {
            this.company = company;
            this.location = location;
        }

        protected string company;
        protected string location;

        public string GetCompany
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public string GetLocation
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public void Specialization()
        {
            Console.WriteLine("Our company specializes in tennis balls");
        }
    }
}
