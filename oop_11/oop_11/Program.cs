using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;



            string[] summer = { "June", "July", "August" };
            string[] winter = { "December", "January", "February" };

            string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };



            var FirstRequest = Months.Where(t => t.Length == n);
            foreach (var item in FirstRequest)
                Console.WriteLine(item);

            var SecondRequest = Months.Where(t => (summer.Contains(t) || winter.Contains(t)));
            foreach (var item in SecondRequest)
                Console.WriteLine(item);

            var ThirdRequest = Months.OrderBy(t => t);
            foreach (var item in ThirdRequest)
                Console.WriteLine(item);

            var FourthRequest = Months.Where(t => t.Contains('u') && t.Length >= 4);
            foreach (var item in FourthRequest)
                Console.WriteLine(item);

            DateTime old = new DateTime(2000);
            DateTime average = new DateTime(2005);
            List<Bus> buses = new List<Bus>()
            {
                new Bus(new DateTime(2013, 12, 1),"Some", "11", "VN12", 2009, 13444),
                new Bus(new DateTime(2014, 2, 1), "body", "11", "VN12", 2000, 18912),
                new Bus(new DateTime(2016, 3, 1), "once", "19A", "VN12", 1999, 23900),
                new Bus(DateTime.Now,"told","B3","MERC",1,50000),
                new Bus(DateTime.Now,"me", "C5","Volskvagen", 6, 74322),
                new Bus(DateTime.Now,"the", "C1", "MAZ",8,123123),
                new Bus(DateTime.Now,"world", "C3","MAZ", 17,54212),
                new Bus(DateTime.Now,"is","C3","Volskvagen",87,123132)
            };

            var BusRouteRequest = buses.Where(item => item.RouteNum == "11");
            var BusTimeRequest = buses.Where(item => item.Age > 1);
            var BusMinRequest = buses.Min(item => item.Mileage);
            var BusLastByMaxRequest = buses.OrderBy(item => item.Mileage);
            var BusSortRequest = buses.OrderBy(item => item.BusNum);

            var operMonths = Months.Where(item => item.Length > 3).OrderBy(item => item.Length).Aggregate("March", (longest, next) =>
            next.Length >= longest.Length ? next : longest, item => item.ToUpper()).Select(item => item);
            foreach (var item in operMonths)
                Console.WriteLine(item);

            List<Person> people = new List<Person>()
            {
                new Person { ID = 123, name = "Viktor" },
                new Person { ID = 1, name = "Petrov" }
            };
            List<Job> companies = new List<Job>()
            {
                new Job { company = "CCD", ID = 123 },
                new Job { company = "BBQ", ID = 1 }
            };

            var emp = people.Join(companies, fst => fst.name, scd => scd.company, (fst, scd) => new { name = fst.name, company = scd.company, ID = fst.ID });

        }
    }
    class Person
    {
        public string name;
        public int ID;
    }
    class Job
    {
        public string company;
        public int ID;
    }
}
