using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace oop_11
{
    public partial class Bus
    {
        //static
        static readonly DateTime dateCreationOfPark;

        private static ushort quantity = 0;

        //public
        private const string typeOfVehicle = "Bus";

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string routeNum;

        public string RouteNum
        {
            get
            {
                return routeNum;
            }
            set
            {
                routeNum = value;
            }
        }

        private string vehicleMark;

        public string VehicleMark
        {
            get
            {
                return vehicleMark;
            }
            set
            {
                vehicleMark = value;
            }
        }

        private uint busNum;

        public uint BusNum
        {
            get
            {
                return busNum;
            }
            set
            {
                if (value > busNum)
                    Console.WriteLine("Incorrect value!");
                else
                    busNum = value;
            }
        }

        //private
        private readonly double ID;

        private uint mileage;

        public uint Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                if (mileage < 0)
                    Console.WriteLine("Incorrect value!");
                else
                    mileage = value;
            }
        }



        private int age;

        public int Age
        {
            get
            {
                return (DateTime.Now.Year - startInUsing.Year);
            }
        }

        private DateTime startInUsing;

        public DateTime StartInUsing
        {
            get
            {
                return startInUsing;
            }
        }
        private void countHash(uint mileage, DateTime startInUsing, string name, out double ID)
        {
            ID = (Math.Pow(mileage, startInUsing.Year) / name.Length);
        }

        public void changeName(ref string fullname)
        {
            fullname = Console.ReadLine();
        }



        public Bus()
        {
            this.name = "Trainee";
            this.routeNum = "Autodrome";
            this.vehicleMark = "MAZ";
            this.busNum = 5683;
            this.mileage = 0;
            this.startInUsing = new DateTime(2010, 10, 3);
            countHash(mileage, startInUsing, name, out ID);
            quantity++;
        }

        public Bus(string fullname = "Trainee") : this()
        {
            this.name = fullname;
        }
        public Bus(
           DateTime inUsingYear,
           string name,
           string routeNum,
           string vehicleMark,
           uint busNum,
           uint mileage) : this()
        {
            if (DateTime.Now.Year - inUsingYear.Year > 100)
            {
                Console.WriteLine("Incorrect value!");
                this.startInUsing = DateTime.Now;
            }
            else
                this.startInUsing = inUsingYear;

            this.name = name;
            this.routeNum = routeNum;
            this.vehicleMark = vehicleMark;
            this.busNum = busNum;
            this.mileage = mileage;
        }

        static Bus()
        {
            dateCreationOfPark = DateTime.Now;
            Console.WriteLine("You will see this message only one time.\n Park was created!");
        }

        public override bool Equals(Object obj)
        {
            Bus forOverride = obj as Bus;
            return (
                name == forOverride.name &&
                routeNum == forOverride.routeNum &&
                vehicleMark == forOverride.vehicleMark &&
                busNum == forOverride.busNum &&
                mileage == forOverride.mileage &&
                startInUsing == forOverride.startInUsing
                );
        }

        public override int GetHashCode()
        {
            return (int)ID;
        }

        public override string ToString()
        {
            return $"Bus {vehicleMark} number {busNum}, route {routeNum}, meliage {mileage}\n" +
                $", used since {startInUsing} by {name}";
        }

        public void ShowAge()
        {
            Console.WriteLine($"Age of bus:{this.Age} year");
        }
    }
    public partial class Bus
    {
        public void showClassInfo()
        {
            Console.WriteLine($"Quantity of objects:{quantity}");
        }
    }



}
