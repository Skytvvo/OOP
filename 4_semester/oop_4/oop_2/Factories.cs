using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    [Serializable]
    public class ServerFactory : IFactory
    {
        public ComputerConfig CreateConfig()
        {
            return new ServerDefaultConfig();
        }

        public ComputerHardware CreateHardware()
        {
            return new ServerHardware();
        }
    }
    [Serializable]
    public class PCFactory : IFactory
    {
        public ComputerConfig CreateConfig()
        {
            return new PCDefaultConfig();
        }

        public ComputerHardware CreateHardware()
        {
            return new PCHardware();
        }
    }

    [Serializable]

    public class LaptopFactory : IFactory
    {
        public ComputerConfig CreateConfig()
        {
            return new LaptopDefaultConfig();
        }

        public ComputerHardware CreateHardware()
        {
            return new LaptopHardware();
        }
    }

    [Serializable]
    public class WorkStationFactory : IFactory
    {
        public ComputerConfig CreateConfig()
        {
            return new WorkStationDefaultConfig();
        }

        public ComputerHardware CreateHardware()
        {
            return new WorkStationHardware();
        }
    }
}
