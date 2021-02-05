using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace oop_14
{
    class Program
    {

        static void Main(string[] args)
        {
            Sport shockShake = new Sport("Box");

            BinaryFormatter bf = new BinaryFormatter();

            string binaryPath = @".\byte.txt";

            using (FileStream sw = new FileStream(binaryPath, FileMode.OpenOrCreate))
            {
                bf.Serialize(sw, shockShake);
                Console.WriteLine("Serialize by binaryFormater");
            }
            using (FileStream sr = new FileStream(binaryPath, FileMode.OpenOrCreate))
            {
                Sport shock = (Sport)bf.Deserialize(sr);
                Console.WriteLine(shock.ToString());
            }

            string jsoonPath = @"./jsonFile.json";

            using( FileStream sw = new FileStream(jsoonPath,FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Sport));
                jsonSerializer.WriteObject(sw,shockShake);
                Console.WriteLine("Serialize by json");
            }
            
            using(FileStream sr = new FileStream(jsoonPath, FileMode.OpenOrCreate) )
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Sport));
                Sport sp = (Sport)jsonSerializer.ReadObject(sr);
                Console.WriteLine(sp.ToString());
            }

            string soapPath = @".\soap.soap";

            SoapFormatter formatter = new SoapFormatter();

            using (FileStream sw = new FileStream(soapPath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(sw, shockShake);
                Console.WriteLine("Soap serialization");
            }

            using(FileStream sr = new FileStream(soapPath, FileMode.OpenOrCreate))
            {
                Sport sport = (Sport)formatter.Deserialize(sr);
                Console.WriteLine(sport.ToString());
            }

            string xmlPath = @".\xml.xml";
            XmlSerializer xmlFor = new XmlSerializer(typeof(Sport)); 
            using(FileStream sw = new FileStream(xmlPath, FileMode.OpenOrCreate))
            {
                xmlFor.Serialize(sw, shockShake);
                Console.WriteLine("XML serialization");
            }
            using(FileStream sr = new FileStream(xmlPath, FileMode.OpenOrCreate))
            {
                Sport sport = (Sport)xmlFor.Deserialize(sr);
                Console.WriteLine(sport.ToString());
            }

            string pathArr = @".\arr.txt";

            Sport[] sports = { new Sport("Hello"), new Sport("From"), new Sport("dude") };
            using(FileStream sw = new FileStream(pathArr, FileMode.OpenOrCreate))
            {
                bf.Serialize(sw, sports);
            }
            using(FileStream sw = new FileStream(pathArr, FileMode.OpenOrCreate))
            {
                Sport[] newArr = (Sport[])bf.Deserialize(sw);
                foreach (var item in newArr)
                    Console.WriteLine(item.GetName);
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            XmlElement block = doc.DocumentElement;
            XmlNodeList nodes = block.SelectNodes("*");
            foreach (XmlNode n in nodes)
                Console.WriteLine(n.OuterXml);
            nodes = block.SelectNodes("GetName");
            foreach (XmlNode n in nodes)
                Console.WriteLine(n.OuterXml);

            XDocument xdoc = XDocument.Load(@"D:\projects\labs\3-semester\oop\oop_14\oop_14\bin\Debug\xmlFil.xml");

            var items = from xe in xdoc.Element("users").Elements("user")
                        where xe.Element("company").Value == "Microsoft"
                        select new { Company = xe.Element("age").Value};
            foreach (var item in items)
                Console.WriteLine(item.Company);
        }
    }
}
