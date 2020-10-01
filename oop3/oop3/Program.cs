using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace oop3
{

    class Timetable
    { 
        private Timetable(){}
        public static DateTime firstBus = DateTime.Today;
    }
  
    class Program
    {
        static void Main(string[] args)
        { 
            Bus A1 = new Bus(new DateTime(2018, 12, 1),"Franchesko", "11", "VN12", 2009, 13444);
            Bus A2 = new Bus(new DateTime(2019, 2, 1),"Mario", "11", "VN12", 2000, 18912);
            Bus B18 = new Bus(new DateTime(2019, 3, 1),"Franciua", "19A", "VN12", 1999, 23900);
            Bus C1 = new Bus("Abele");
            Bus trainee = new Bus();

            A1.showClassInfo();
            //output with using get
            Console.WriteLine($"Get: {A1.Name},{A2.Mileage},{B18.RouteNum},{C1.VehicleMark},{trainee.StartInUsing}");
            
            //set
            trainee.Name = "Alex";
            trainee.Mileage = 0;
            trainee.RouteNum = "S1";
            trainee.BusNum = 1000;

            A1.Equals(A2);
            int hash = B18.GetHashCode();
            Console.WriteLine($"Get type:\n" +
                $"A1:{A1.GetType()}\n" +
                $"A2:{A2.GetType()}\n" +
                $"C1:{C1.GetType()}\n");


            Bus[] park = new Bus[]
                {
                    A1,
                    A2,
                    B18,
                    C1,
                    trainee
                };

            //TASKS

            //1
            string userCheckRoute = Console.ReadLine();

            foreach(Bus item in park)
            {
                if(string.Compare(userCheckRoute, item.RouteNum) == 0)
                {
                    Console.WriteLine($"{item.RouteNum}: {item.BusNum}, driver: {item.Name}, {item.Mileage} km");
                }
            }

            //2
            int userInputAge = Convert.ToInt32(Console.ReadLine());
            foreach(Bus item in park)
            {
                if(item.Age > userInputAge)
                {
                    Console.WriteLine($"{item.RouteNum}: {item.BusNum}, driver: {item.Name}, {item.Mileage} km");
                }
            }

                

            var D12 = new { InUsingDate = new DateTime(2020, 12, 2),
            Name = "Abella", Route = "19A", VehicleMark = "BELAZ12", BusNum = 1223, Mileage = 512};

            var D13 = new Bus();

            Console.WriteLine($"{D13.Mileage},{D13.BusNum},{D13.RouteNum},{D13.Name}");
        }
    }
}
