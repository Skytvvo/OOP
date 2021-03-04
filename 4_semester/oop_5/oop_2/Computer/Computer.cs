using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace oop_2
{

    public interface IComputer
    {
        IComputer Clone();
    }

    [Serializable]
    [XmlInclude(typeof(WorkStationDefaultConfig))]
    [XmlInclude(typeof(WorkStationHardware))]
    public class Computer : IComputer 
    {
        
        public Computer()
        {

        }
        

        public ComputerConfig config;
        

        public ComputerHardware hardware;
       
        

        public Computer(IFactory factory)
        {
            config = factory.CreateConfig();
            hardware = factory.CreateHardware();
        }

        public IComputer Clone()
        {
            return this.MemberwiseClone() as IComputer;
        }

        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binFormatter.Deserialize(tempStream);
            }
            return figure;
        }

    }
}
